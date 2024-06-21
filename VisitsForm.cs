using System;
//using System.Data.Entity;
using System.Drawing;
using System.Linq;
//using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using VisioForge_SDK_Video_Capture_Demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WinForm
{
    public partial class VisitsForm : Form
    {
        private MyDbContext _context;
        private IConfiguration Configuration;
        private int VisitId;
        private CVisit currentVisit;
        public VisitsForm(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
            InitializeComponent();
            initializeDbContext();
        }

        private void initializeDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
            var connectString = Configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseNpgsql(connectString);

            var options = optionsBuilder.Options;
            _context = new MyDbContext(options);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void VisitsForm_Load_1(object sender, EventArgs e)
        {

            var formVisitId = _context.dbVisits.FirstOrDefault()?.Id ?? 0;
            // var formVisitId = _context.dbVisits.ToList()[0];
            this.VisitId = formVisitId;



            try
            {
                populateVisitFormLabels();


                populatePatientGrid();

                // imageboxes

                populateVisitImages();

                bindVisitFormFields();


            }
            catch (Exception ex)
            {
                var sinfo = ex.Message;
                if (ex.InnerException != null)
                {
                    sinfo += "\nInner Exception: " + ex.InnerException.Message;
                }
                MessageBox.Show(sinfo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }


        void bindVisitFormFields()
        {

            // creating a new visit and updating patient id. returning this.visitId
            var visit = new CVisit();
            visit.PatientId = 1;
            _context.dbVisits.Add(visit);
            _context.SaveChanges();
            this.VisitId = visit.Id;
            this.currentVisit = visit;

        }

        public static Binding CreateCheckoxBindingWithFormat(string propertyName, object dataSource, string dataMember)
        {
            var binding = new Binding(propertyName, dataSource, dataMember);
            binding.Format += (s, e) =>
            {
                e.Value = e.Value != null ? Convert.ToBoolean(e.Value) : false;
            };
            return binding;
        }

        void populateVisitImages()
        {

            flowLayoutPanel1.Controls.Clear();

            var visitWithImages = _context.dbVisits
            .Include(v => v.Images)
            .FirstOrDefault(v => v.Id == this.VisitId); // this.VisitId is setup on Form Load.

            if (visitWithImages is not null)
            {
                foreach (var image in visitWithImages.Images)
                {
                    Console.WriteLine(image.ImagePath);
                }

                flowLayoutPanel1.AutoScroll = true;

                foreach (var image in visitWithImages.Images) // replace imagePaths with your list of image paths
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(image.ImagePath);

                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Width = flowLayoutPanel1.Width;


                    pictureBox.Height = pictureBox.Image.Height * 1000 / (pictureBox.Image.Width * 1000 / pictureBox.Width);
                    //pictureBox.Height  = calcImageBoxHeight(pictureBox.Image.Height, pictureBox.Image.Width, pictureBox.Width);

                    Button deleteButton = new Button();
                    deleteButton.Text = "Delete"; // or set the Image property to display an icon
                    deleteButton.Click += (s, ev) =>
                    {
                        flowLayoutPanel1.Controls.Remove(pictureBox);
                        flowLayoutPanel1.Controls.Remove(deleteButton);
                        // Optionally, delete the image file itself:
                        // System.IO.File.Delete(image.ImagePath);
                    };

                    flowLayoutPanel1.Controls.Add(pictureBox);
                    flowLayoutPanel1.Controls.Add(deleteButton);


                }

                //this.Controls.Add(flowLayoutPanel1);
                this.tabControl1.TabPages["tabImages"].Controls.Add(flowLayoutPanel1);
            }

        }


        void populateVisitFormLabels()
        {
            cbP1.Text = Configuration.GetSection("Visit:p1").Value;
            cbP2.Text = Configuration.GetSection("Visit:p2").Value;
            cbP3.Text = Configuration.GetSection("Visit:p3").Value;
            cbP4.Text = Configuration.GetSection("Visit:p4").Value;
            cbP5.Text = Configuration.GetSection("Visit:p5").Value;
            lbP1Text.Text = Configuration.GetSection("Visit:p1text").Value;
            lbP2Text.Text = Configuration.GetSection("Visit:p2text").Value;
            lbP3Text.Text = Configuration.GetSection("Visit:p3text").Value;
            lbP4Text.Text = Configuration.GetSection("Visit:p4text").Value;
            lbP5Text.Text = Configuration.GetSection("Visit:p5text").Value;
        }







        int calcImageBoxHeight(int imageHeight, int imageWidth, int boxWidth)
        // Fixme!
        {
            return imageHeight * 1000 / imageWidth * 1000 / boxWidth;
        }




        void populatePatientGrid()
        {

            try
            {


                BindingSource bsource = new BindingSource();
                bsource.DataSource = _context.dbPersons.ToList();
                gridPatients.DataSource = null;
                gridPatients.DataSource = bsource;

                //CTableFormat cTableFormat = new CTableFormat();
                //cTableFormat.FormatColumnGrid(ref dGridPostgres, 1);
                gridPatients.CellDoubleClick += gridPatients_CellDoubleClick;



            }
            catch (Exception ex)
            {
                var sinfo = ex.Message;
                if (ex.InnerException != null)
                {
                    sinfo += "\nInner Exception: " + ex.InnerException.Message;
                }
                MessageBox.Show(sinfo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void gridPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a row was double-clicked, not a column header
            if (e.RowIndex >= 0)
            {
                // Get the data of the row that was double-clicked
                DataGridViewRow row = this.gridPatients.Rows[e.RowIndex];

                // Access the data
                var id = row.Cells["Id"].Value;
                var name = row.Cells["name"].Value;

                // Use the data
                MessageBox.Show($"Id: {id}, Name: {name}");
            }
        }

        void btnRefreshImages_Click(object sender, EventArgs e)
        {
            populateVisitImages();
        }

        void button1_Click(object sender, EventArgs e) { }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnVisitSave_Click(object sender, EventArgs e)
        {

            // Retrieve the visit from the database
            var visit = _context.dbVisits.FirstOrDefault(v => v.Id == this.VisitId);


            if (visit != null)
            {
                try
                {
                    visit.Alergijas = cbAlergijas.Checked;
                    visit.Anamneze = fldAnamneze.Text;
                    visit.IzmeklejumaNr = fldIzmeklejumaNr.Text;
                    visit.IzmeklejumaDatums = fldIzmeklejumaDatums.Value;
                    visit.IepriekshVeiktaTerapija = fldIeprkshVeiktaTerapija.Text;
                    visit.SkriningaNr = fldSkriningaNummurs.Text;
                    visit.NakosaKolposkopijasKontrole = fldNakosaKolposkKontrole.Value;
                    visit.Rezultati = fldRezultati.Text;
                    visit.Sledziens = fldSledziens.Text;
                    visit.TrnsformacijasZonasTips = fldTrnsformacijasZonasTips.Text;
                    visit.VizitesAtkartojums = fldVizitesAtkartojums.Text;
                    visit.VizitePirmreizejaAtkartota = rbVizitePirmreizeja.Checked;
                    visit.p1 = cbP1.Checked;
                    visit.p2 = cbP2.Checked;
                    visit.p3 = cbP3.Checked;
                    visit.p4 = cbP4.Checked;
                    visit.p5 = cbP5.Checked;
                    visit.m1 = cbM1.Checked;
                    visit.m2 = cbM2.Checked;
                    visit.m3 = cbM3.Checked;


                    // Save the changes to the database
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    var sinfo = ex.Message;
                    if (ex.InnerException != null)
                    {
                        sinfo += "\nInner Exception: " + ex.InnerException.Message;
                    }
                    MessageBox.Show($" error saving Visit form: \n{sinfo}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




            // Create a new BindingSource


            /*
            var visit = _context.dbVisits.Find(this.VisitId);

            if (visit is not null)
            {
                
                visit.IzmeklejumaDatums = fldIzmeklejumaDatums.Value;
                visit.IzmeklejumaNr = fldIzmeklejumaNr.Text;
                visit.Alergijas = fldAlergijasTrue.Checked ? "Yes" : "No";

                visit.IzmeklejumaNr { get; set; }
                visit.IzmeklejumaDatums { get; set; }
    // DateTime dateOnly = visit.IzmeklejumaDatums.Date;
 
            visit.VizitesAtkartojums { get; set; }
                visit.SkriningaNr { get; set; }
                visit.Anamneze { get; set; }
                visit.IepriekshVeiktaTerapija { get; set; }
                visit.Alergijas { get; set; }
                visit.TrnsformacijasZonasTips { get; set; }
                visit.p1 { get; set; }
                visit.p2 { get; set; }
                visit.p3 { get; set; }
                visit.p4 { get; set; }
                visit.p5 { get; set; }
                visit.m1 { get; set; }
                visit.m2 { get; set; }
                visit.m3 { get; set; }
                visit.Rezultati { get; set; }
                visit.Sledziens { get; set; }
                visit.NakosaKolposkopijasKontrole { get; set; }
                */

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }




}

