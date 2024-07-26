using VisioForge.Core.Types;
using System;
using VisioForge.Core.UI.WinForms;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace VisioForge_SDK_Video_Capture_Demo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            mpegTSSettingsDialog?.Dispose();
            mpegTSSettingsDialog = null;

            mp4SettingsDialog?.Dispose();
            mp4SettingsDialog = null;

            mp4HWSettingsDialog?.Dispose();
            mp4HWSettingsDialog = null;

            movSettingsDialog?.Dispose();
            movSettingsDialog = null;

            gifSettingsDialog?.Dispose();
            gifSettingsDialog = null;

            aviSettingsDialog?.Dispose();
            aviSettingsDialog = null;

            wmvSettingsDialog?.Dispose();
            wmvSettingsDialog = null;

            screenshotSaveDialog?.Dispose();
            screenshotSaveDialog = null;

            tmRecording?.Dispose();
            tmRecording = null;

            VideoCapture1?.Dispose();
            VideoCapture1 = null;

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btStop = new Button();
            btStart = new Button();
            tcMain = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            cbUseBestVideoInputFormat = new System.Windows.Forms.CheckBox();
            btVideoCaptureDeviceSettings = new Button();
            label18 = new Label();
            cbVideoInputFrameRate = new ComboBox();
            cbVideoInputFormat = new ComboBox();
            cbVideoInputDevice = new ComboBox();
            label13 = new Label();
            label11 = new Label();
            tabPage2 = new TabPage();
            cbOutputFormat = new ComboBox();
            label7 = new Label();
            tabPage3 = new TabPage();
            cbScrollingText = new System.Windows.Forms.CheckBox();
            cbMergeTextLogos = new System.Windows.Forms.CheckBox();
            cbMergeImageLogos = new System.Windows.Forms.CheckBox();
            cbFlipY = new System.Windows.Forms.CheckBox();
            cbFlipX = new System.Windows.Forms.CheckBox();
            cbInvert = new System.Windows.Forms.CheckBox();
            cbGreyscale = new System.Windows.Forms.CheckBox();
            label201 = new Label();
            tbDarkness = new TrackBar();
            label200 = new Label();
            label199 = new Label();
            label198 = new Label();
            tbContrast = new TrackBar();
            tbLightness = new TrackBar();
            tbSaturation = new TrackBar();
            label3 = new Label();
            btTextLogoAdd = new Button();
            btLogoRemove = new Button();
            btLogoEdit = new Button();
            lbLogos = new ListBox();
            btImageLogoAdd = new Button();
            label2 = new Label();
            tabZoom = new TabPage();
            label6 = new Label();
            label5 = new Label();
            groupBox37 = new System.Windows.Forms.GroupBox();
            btEffZoomRight = new Button();
            btEffZoomLeft = new Button();
            btEffZoomOut = new Button();
            btEffZoomIn = new Button();
            btEffZoomDown = new Button();
            btEffZoomUp = new Button();
            cbZoom = new System.Windows.Forms.CheckBox();
            tabPage4 = new TabPage();
            cbDebugMode = new System.Windows.Forms.CheckBox();
            mmLog = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog2 = new OpenFileDialog();
            fontDialog1 = new FontDialog();
            btSaveScreenshot = new Button();
            btResume = new Button();
            btPause = new Button();
            VideoView1 = new VideoView();
            label4 = new Label();
            lbLastScreenCaptureStatus = new Label();
            tcMain.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbDarkness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbContrast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbLightness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSaturation).BeginInit();
            tabZoom.SuspendLayout();
            groupBox37.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // btStop
            // 
            btStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            btStop.Location = new System.Drawing.Point(110, 681);
            btStop.Margin = new Padding(4, 5, 4, 5);
            btStop.Name = "btStop";
            btStop.Size = new System.Drawing.Size(82, 35);
            btStop.TabIndex = 54;
            btStop.Text = "Stop";
            btStop.UseVisualStyleBackColor = true;
            btStop.Click += btStop_Click;
            // 
            // btStart
            // 
            btStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            btStart.Location = new System.Drawing.Point(20, 681);
            btStart.Margin = new Padding(4, 5, 4, 5);
            btStart.Name = "btStart";
            btStart.Size = new System.Drawing.Size(82, 35);
            btStart.TabIndex = 53;
            btStart.Text = "Start";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // tcMain
            // 
            tcMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tcMain.Controls.Add(tabPage1);
            tcMain.Controls.Add(tabPage2);
            tcMain.Controls.Add(tabPage3);
            tcMain.Controls.Add(tabZoom);
            tcMain.Controls.Add(tabPage4);
            tcMain.Location = new System.Drawing.Point(4, 5);
            tcMain.Margin = new Padding(4, 5, 4, 5);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new System.Drawing.Size(506, 653);
            tcMain.TabIndex = 49;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(cbUseBestVideoInputFormat);
            tabPage1.Controls.Add(btVideoCaptureDeviceSettings);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(cbVideoInputFrameRate);
            tabPage1.Controls.Add(cbVideoInputFormat);
            tabPage1.Controls.Add(cbVideoInputDevice);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label11);
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new System.Drawing.Size(498, 620);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Devices";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(452, 142);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 20);
            label1.TabIndex = 128;
            label1.Text = "fps";
            // 
            // cbUseBestVideoInputFormat
            // 
            cbUseBestVideoInputFormat.AutoSize = true;
            cbUseBestVideoInputFormat.Location = new System.Drawing.Point(250, 110);
            cbUseBestVideoInputFormat.Margin = new Padding(4, 5, 4, 5);
            cbUseBestVideoInputFormat.Name = "cbUseBestVideoInputFormat";
            cbUseBestVideoInputFormat.Size = new System.Drawing.Size(87, 24);
            cbUseBestVideoInputFormat.TabIndex = 127;
            cbUseBestVideoInputFormat.Text = "Use best";
            cbUseBestVideoInputFormat.UseVisualStyleBackColor = true;
            cbUseBestVideoInputFormat.CheckedChanged += cbUseBestVideoInputFormat_CheckedChanged;
            // 
            // btVideoCaptureDeviceSettings
            // 
            btVideoCaptureDeviceSettings.Location = new System.Drawing.Point(358, 52);
            btVideoCaptureDeviceSettings.Margin = new Padding(4, 5, 4, 5);
            btVideoCaptureDeviceSettings.Name = "btVideoCaptureDeviceSettings";
            btVideoCaptureDeviceSettings.Size = new System.Drawing.Size(88, 35);
            btVideoCaptureDeviceSettings.TabIndex = 126;
            btVideoCaptureDeviceSettings.Text = "Settings";
            btVideoCaptureDeviceSettings.UseVisualStyleBackColor = true;
            btVideoCaptureDeviceSettings.Click += btVideoCaptureDeviceSettings_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(354, 112);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(80, 20);
            label18.TabIndex = 125;
            label18.Text = "Frame rate";
            // 
            // cbVideoInputFrameRate
            // 
            cbVideoInputFrameRate.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVideoInputFrameRate.FormattingEnabled = true;
            cbVideoInputFrameRate.Location = new System.Drawing.Point(358, 137);
            cbVideoInputFrameRate.Margin = new Padding(4, 5, 4, 5);
            cbVideoInputFrameRate.Name = "cbVideoInputFrameRate";
            cbVideoInputFrameRate.Size = new System.Drawing.Size(86, 28);
            cbVideoInputFrameRate.TabIndex = 124;
            // 
            // cbVideoInputFormat
            // 
            cbVideoInputFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVideoInputFormat.FormattingEnabled = true;
            cbVideoInputFormat.Location = new System.Drawing.Point(12, 137);
            cbVideoInputFormat.Margin = new Padding(4, 5, 4, 5);
            cbVideoInputFormat.Name = "cbVideoInputFormat";
            cbVideoInputFormat.Size = new System.Drawing.Size(328, 28);
            cbVideoInputFormat.TabIndex = 123;
            cbVideoInputFormat.SelectedIndexChanged += cbVideoInputFormat_SelectedIndexChanged;
            // 
            // cbVideoInputDevice
            // 
            cbVideoInputDevice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVideoInputDevice.FormattingEnabled = true;
            cbVideoInputDevice.Location = new System.Drawing.Point(12, 55);
            cbVideoInputDevice.Margin = new Padding(4, 5, 4, 5);
            cbVideoInputDevice.Name = "cbVideoInputDevice";
            cbVideoInputDevice.Size = new System.Drawing.Size(328, 28);
            cbVideoInputDevice.TabIndex = 122;
            cbVideoInputDevice.SelectedIndexChanged += cbVideoInputDevice_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(6, 112);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(135, 20);
            label13.TabIndex = 121;
            label13.Text = "Video input format";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(8, 30);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(133, 20);
            label11.TabIndex = 120;
            label11.Text = "Video input device";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cbOutputFormat);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new System.Drawing.Size(498, 620);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Output";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbOutputFormat
            // 
            cbOutputFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOutputFormat.FormattingEnabled = true;
            cbOutputFormat.Items.AddRange(new object[] { "AVI", "WMV (Windows Media Video)", "MP4 (CPU)", "MP4 (GPU: Intel, Nvidia, AMD/ATI)", "Animated GIF", "MPEG-TS", "MOV" });
            cbOutputFormat.Location = new System.Drawing.Point(22, 50);
            cbOutputFormat.Margin = new Padding(4, 5, 4, 5);
            cbOutputFormat.Name = "cbOutputFormat";
            cbOutputFormat.Size = new System.Drawing.Size(462, 28);
            cbOutputFormat.TabIndex = 122;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(18, 25);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(56, 20);
            label7.TabIndex = 120;
            label7.Text = "Format";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(cbScrollingText);
            tabPage3.Controls.Add(cbMergeTextLogos);
            tabPage3.Controls.Add(cbMergeImageLogos);
            tabPage3.Controls.Add(cbFlipY);
            tabPage3.Controls.Add(cbFlipX);
            tabPage3.Controls.Add(cbInvert);
            tabPage3.Controls.Add(cbGreyscale);
            tabPage3.Controls.Add(label201);
            tabPage3.Controls.Add(tbDarkness);
            tabPage3.Controls.Add(label200);
            tabPage3.Controls.Add(label199);
            tabPage3.Controls.Add(label198);
            tabPage3.Controls.Add(tbContrast);
            tabPage3.Controls.Add(tbLightness);
            tabPage3.Controls.Add(tbSaturation);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(btTextLogoAdd);
            tabPage3.Controls.Add(btLogoRemove);
            tabPage3.Controls.Add(btLogoEdit);
            tabPage3.Controls.Add(lbLogos);
            tabPage3.Controls.Add(btImageLogoAdd);
            tabPage3.Controls.Add(label2);
            tabPage3.Location = new System.Drawing.Point(4, 29);
            tabPage3.Margin = new Padding(4, 5, 4, 5);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4, 5, 4, 5);
            tabPage3.Size = new System.Drawing.Size(498, 620);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Video effects";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbScrollingText
            // 
            cbScrollingText.AutoSize = true;
            cbScrollingText.Location = new System.Drawing.Point(70, 535);
            cbScrollingText.Margin = new Padding(2);
            cbScrollingText.Name = "cbScrollingText";
            cbScrollingText.Size = new System.Drawing.Size(170, 24);
            cbScrollingText.TabIndex = 88;
            cbScrollingText.Text = "Sample scrolling text";
            cbScrollingText.UseVisualStyleBackColor = true;
            cbScrollingText.CheckedChanged += cbScrollingText_CheckedChanged;
            // 
            // cbMergeTextLogos
            // 
            cbMergeTextLogos.AutoSize = true;
            cbMergeTextLogos.Location = new System.Drawing.Point(250, 238);
            cbMergeTextLogos.Margin = new Padding(4, 5, 4, 5);
            cbMergeTextLogos.Name = "cbMergeTextLogos";
            cbMergeTextLogos.Size = new System.Drawing.Size(203, 24);
            cbMergeTextLogos.TabIndex = 87;
            cbMergeTextLogos.Text = "Merge text logos into one";
            cbMergeTextLogos.UseVisualStyleBackColor = true;
            // 
            // cbMergeImageLogos
            // 
            cbMergeImageLogos.AutoSize = true;
            cbMergeImageLogos.Location = new System.Drawing.Point(16, 238);
            cbMergeImageLogos.Margin = new Padding(4, 5, 4, 5);
            cbMergeImageLogos.Name = "cbMergeImageLogos";
            cbMergeImageLogos.Size = new System.Drawing.Size(220, 24);
            cbMergeImageLogos.TabIndex = 86;
            cbMergeImageLogos.Text = "Merge image logos into one";
            cbMergeImageLogos.UseVisualStyleBackColor = true;
            // 
            // cbFlipY
            // 
            cbFlipY.AutoSize = true;
            cbFlipY.Location = new System.Drawing.Point(336, 505);
            cbFlipY.Margin = new Padding(4, 5, 4, 5);
            cbFlipY.Name = "cbFlipY";
            cbFlipY.Size = new System.Drawing.Size(67, 24);
            cbFlipY.TabIndex = 85;
            cbFlipY.Text = "Flip Y";
            cbFlipY.UseVisualStyleBackColor = true;
            cbFlipY.CheckedChanged += cbFlipY_CheckedChanged;
            // 
            // cbFlipX
            // 
            cbFlipX.AutoSize = true;
            cbFlipX.Location = new System.Drawing.Point(256, 505);
            cbFlipX.Margin = new Padding(4, 5, 4, 5);
            cbFlipX.Name = "cbFlipX";
            cbFlipX.Size = new System.Drawing.Size(68, 24);
            cbFlipX.TabIndex = 84;
            cbFlipX.Text = "Flip X";
            cbFlipX.UseVisualStyleBackColor = true;
            cbFlipX.CheckedChanged += cbFlipX_CheckedChanged;
            // 
            // cbInvert
            // 
            cbInvert.AutoSize = true;
            cbInvert.BackgroundImageLayout = ImageLayout.Center;
            cbInvert.Location = new System.Drawing.Point(176, 505);
            cbInvert.Margin = new Padding(4, 5, 4, 5);
            cbInvert.Name = "cbInvert";
            cbInvert.Size = new System.Drawing.Size(68, 24);
            cbInvert.TabIndex = 83;
            cbInvert.Text = "Invert";
            cbInvert.UseVisualStyleBackColor = true;
            cbInvert.CheckedChanged += cbInvert_CheckedChanged;
            // 
            // cbGreyscale
            // 
            cbGreyscale.AutoSize = true;
            cbGreyscale.Location = new System.Drawing.Point(70, 505);
            cbGreyscale.Margin = new Padding(4, 5, 4, 5);
            cbGreyscale.Name = "cbGreyscale";
            cbGreyscale.Size = new System.Drawing.Size(94, 24);
            cbGreyscale.TabIndex = 82;
            cbGreyscale.Text = "Greyscale";
            cbGreyscale.UseVisualStyleBackColor = true;
            cbGreyscale.CheckedChanged += cbGreyscale_CheckedChanged;
            // 
            // label201
            // 
            label201.AutoSize = true;
            label201.Location = new System.Drawing.Point(246, 397);
            label201.Margin = new Padding(4, 0, 4, 0);
            label201.Name = "label201";
            label201.Size = new System.Drawing.Size(68, 20);
            label201.TabIndex = 81;
            label201.Text = "Darkness";
            // 
            // tbDarkness
            // 
            tbDarkness.BackColor = System.Drawing.SystemColors.Window;
            tbDarkness.Location = new System.Drawing.Point(246, 426);
            tbDarkness.Margin = new Padding(4, 5, 4, 5);
            tbDarkness.Maximum = 255;
            tbDarkness.Name = "tbDarkness";
            tbDarkness.Size = new System.Drawing.Size(174, 56);
            tbDarkness.TabIndex = 80;
            tbDarkness.Scroll += tbDarkness_Scroll;
            // 
            // label200
            // 
            label200.AutoSize = true;
            label200.Location = new System.Drawing.Point(66, 397);
            label200.Margin = new Padding(4, 0, 4, 0);
            label200.Name = "label200";
            label200.Size = new System.Drawing.Size(64, 20);
            label200.TabIndex = 76;
            label200.Text = "Contrast";
            // 
            // label199
            // 
            label199.AutoSize = true;
            label199.Location = new System.Drawing.Point(246, 317);
            label199.Margin = new Padding(4, 0, 4, 0);
            label199.Name = "label199";
            label199.Size = new System.Drawing.Size(77, 20);
            label199.TabIndex = 75;
            label199.Text = "Saturation";
            // 
            // label198
            // 
            label198.AutoSize = true;
            label198.Location = new System.Drawing.Point(66, 317);
            label198.Margin = new Padding(4, 0, 4, 0);
            label198.Name = "label198";
            label198.Size = new System.Drawing.Size(70, 20);
            label198.TabIndex = 74;
            label198.Text = "Lightness";
            // 
            // tbContrast
            // 
            tbContrast.BackColor = System.Drawing.SystemColors.Window;
            tbContrast.Location = new System.Drawing.Point(62, 426);
            tbContrast.Margin = new Padding(4, 5, 4, 5);
            tbContrast.Maximum = 255;
            tbContrast.Name = "tbContrast";
            tbContrast.Size = new System.Drawing.Size(174, 56);
            tbContrast.TabIndex = 73;
            tbContrast.Scroll += tbContrast_Scroll;
            // 
            // tbLightness
            // 
            tbLightness.BackColor = System.Drawing.SystemColors.Window;
            tbLightness.Location = new System.Drawing.Point(62, 340);
            tbLightness.Margin = new Padding(4, 5, 4, 5);
            tbLightness.Maximum = 255;
            tbLightness.Name = "tbLightness";
            tbLightness.Size = new System.Drawing.Size(174, 56);
            tbLightness.TabIndex = 72;
            tbLightness.Scroll += tbLightness_Scroll;
            // 
            // tbSaturation
            // 
            tbSaturation.BackColor = System.Drawing.SystemColors.Window;
            tbSaturation.Location = new System.Drawing.Point(246, 340);
            tbSaturation.Margin = new Padding(4, 5, 4, 5);
            tbSaturation.Maximum = 255;
            tbSaturation.Name = "tbSaturation";
            tbSaturation.Size = new System.Drawing.Size(174, 56);
            tbSaturation.TabIndex = 71;
            tbSaturation.Value = 255;
            tbSaturation.Scroll += tbSaturation_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 14);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(133, 20);
            label3.TabIndex = 69;
            label3.Text = "Text / image logos";
            // 
            // btTextLogoAdd
            // 
            btTextLogoAdd.Location = new System.Drawing.Point(156, 194);
            btTextLogoAdd.Margin = new Padding(4, 5, 4, 5);
            btTextLogoAdd.Name = "btTextLogoAdd";
            btTextLogoAdd.Size = new System.Drawing.Size(132, 35);
            btTextLogoAdd.TabIndex = 68;
            btTextLogoAdd.Text = "Add text logo";
            btTextLogoAdd.UseVisualStyleBackColor = true;
            btTextLogoAdd.Click += btTextLogoAdd_Click;
            // 
            // btLogoRemove
            // 
            btLogoRemove.Location = new System.Drawing.Point(398, 194);
            btLogoRemove.Margin = new Padding(4, 5, 4, 5);
            btLogoRemove.Name = "btLogoRemove";
            btLogoRemove.Size = new System.Drawing.Size(78, 35);
            btLogoRemove.TabIndex = 67;
            btLogoRemove.Text = "Remove";
            btLogoRemove.UseVisualStyleBackColor = true;
            btLogoRemove.Click += btLogoRemove_Click;
            // 
            // btLogoEdit
            // 
            btLogoEdit.Location = new System.Drawing.Point(310, 194);
            btLogoEdit.Margin = new Padding(4, 5, 4, 5);
            btLogoEdit.Name = "btLogoEdit";
            btLogoEdit.Size = new System.Drawing.Size(78, 35);
            btLogoEdit.TabIndex = 66;
            btLogoEdit.Text = "Edit";
            btLogoEdit.UseVisualStyleBackColor = true;
            btLogoEdit.Click += btLogoEdit_Click;
            // 
            // lbLogos
            // 
            lbLogos.FormattingEnabled = true;
            lbLogos.Location = new System.Drawing.Point(16, 38);
            lbLogos.Margin = new Padding(4, 5, 4, 5);
            lbLogos.Name = "lbLogos";
            lbLogos.Size = new System.Drawing.Size(458, 144);
            lbLogos.TabIndex = 65;
            // 
            // btImageLogoAdd
            // 
            btImageLogoAdd.Location = new System.Drawing.Point(16, 194);
            btImageLogoAdd.Margin = new Padding(4, 5, 4, 5);
            btImageLogoAdd.Name = "btImageLogoAdd";
            btImageLogoAdd.Size = new System.Drawing.Size(132, 35);
            btImageLogoAdd.TabIndex = 64;
            btImageLogoAdd.Text = "Add image logo";
            btImageLogoAdd.UseVisualStyleBackColor = true;
            btImageLogoAdd.Click += btImageLogoAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(90, 580);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(338, 20);
            label2.TabIndex = 63;
            label2.Text = "More effects and settings available in Main Demo";
            // 
            // tabZoom
            // 
            tabZoom.Controls.Add(label6);
            tabZoom.Controls.Add(label5);
            tabZoom.Controls.Add(groupBox37);
            tabZoom.Controls.Add(cbZoom);
            tabZoom.Location = new System.Drawing.Point(4, 29);
            tabZoom.Margin = new Padding(2);
            tabZoom.Name = "tabZoom";
            tabZoom.Padding = new Padding(2);
            tabZoom.Size = new System.Drawing.Size(498, 620);
            tabZoom.TabIndex = 2;
            tabZoom.Text = "Zoom";
            tabZoom.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            label6.Location = new System.Drawing.Point(26, 292);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(243, 20);
            label6.TabIndex = 18;
            label6.Text = "please make sure Zoom is checked!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            label5.Location = new System.Drawing.Point(23, 271);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(440, 20);
            label5.TabIndex = 17;
            label5.Text = "please use keyboard add (+) and substract(-) to zoom in and out.";
            // 
            // groupBox37
            // 
            groupBox37.Controls.Add(btEffZoomRight);
            groupBox37.Controls.Add(btEffZoomLeft);
            groupBox37.Controls.Add(btEffZoomOut);
            groupBox37.Controls.Add(btEffZoomIn);
            groupBox37.Controls.Add(btEffZoomDown);
            groupBox37.Controls.Add(btEffZoomUp);
            groupBox37.Location = new System.Drawing.Point(110, 82);
            groupBox37.Margin = new Padding(3, 6, 3, 6);
            groupBox37.Name = "groupBox37";
            groupBox37.Padding = new Padding(3, 6, 3, 6);
            groupBox37.Size = new System.Drawing.Size(159, 160);
            groupBox37.TabIndex = 16;
            groupBox37.TabStop = false;
            groupBox37.Text = "Zoom";
            // 
            // btEffZoomRight
            // 
            btEffZoomRight.Location = new System.Drawing.Point(113, 50);
            btEffZoomRight.Margin = new Padding(3, 6, 3, 6);
            btEffZoomRight.Name = "btEffZoomRight";
            btEffZoomRight.Size = new System.Drawing.Size(29, 74);
            btEffZoomRight.TabIndex = 5;
            btEffZoomRight.Text = "R";
            btEffZoomRight.UseVisualStyleBackColor = true;
            btEffZoomRight.Click += btEffZoomRight_Click;
            // 
            // btEffZoomLeft
            // 
            btEffZoomLeft.Location = new System.Drawing.Point(17, 50);
            btEffZoomLeft.Margin = new Padding(3, 6, 3, 6);
            btEffZoomLeft.Name = "btEffZoomLeft";
            btEffZoomLeft.Size = new System.Drawing.Size(29, 74);
            btEffZoomLeft.TabIndex = 4;
            btEffZoomLeft.Text = "L";
            btEffZoomLeft.UseVisualStyleBackColor = true;
            btEffZoomLeft.Click += btEffZoomLeft_Click;
            // 
            // btEffZoomOut
            // 
            btEffZoomOut.Location = new System.Drawing.Point(81, 70);
            btEffZoomOut.Margin = new Padding(3, 6, 3, 6);
            btEffZoomOut.Name = "btEffZoomOut";
            btEffZoomOut.Size = new System.Drawing.Size(31, 34);
            btEffZoomOut.TabIndex = 3;
            btEffZoomOut.Text = "-";
            btEffZoomOut.UseVisualStyleBackColor = true;
            btEffZoomOut.Click += btEffZoomOut_Click;
            // 
            // btEffZoomIn
            // 
            btEffZoomIn.Location = new System.Drawing.Point(47, 70);
            btEffZoomIn.Margin = new Padding(3, 6, 3, 6);
            btEffZoomIn.Name = "btEffZoomIn";
            btEffZoomIn.Size = new System.Drawing.Size(30, 34);
            btEffZoomIn.TabIndex = 2;
            btEffZoomIn.Text = "+";
            btEffZoomIn.UseVisualStyleBackColor = true;
            btEffZoomIn.Click += btEffZoomIn_Click;
            // 
            // btEffZoomDown
            // 
            btEffZoomDown.Location = new System.Drawing.Point(46, 106);
            btEffZoomDown.Margin = new Padding(3, 6, 3, 6);
            btEffZoomDown.Name = "btEffZoomDown";
            btEffZoomDown.Size = new System.Drawing.Size(67, 34);
            btEffZoomDown.TabIndex = 1;
            btEffZoomDown.Text = "Down";
            btEffZoomDown.UseVisualStyleBackColor = true;
            btEffZoomDown.Click += btEffZoomDown_Click;
            // 
            // btEffZoomUp
            // 
            btEffZoomUp.Location = new System.Drawing.Point(46, 30);
            btEffZoomUp.Margin = new Padding(3, 6, 3, 6);
            btEffZoomUp.Name = "btEffZoomUp";
            btEffZoomUp.Size = new System.Drawing.Size(67, 34);
            btEffZoomUp.TabIndex = 0;
            btEffZoomUp.Text = "Up";
            btEffZoomUp.UseVisualStyleBackColor = true;
            btEffZoomUp.Click += btEffZoomUp_Click;
            // 
            // cbZoom
            // 
            cbZoom.AutoSize = true;
            cbZoom.Checked = true;
            cbZoom.CheckState = CheckState.Checked;
            cbZoom.Location = new System.Drawing.Point(12, 28);
            cbZoom.Margin = new Padding(3, 6, 3, 6);
            cbZoom.Name = "cbZoom";
            cbZoom.Size = new System.Drawing.Size(85, 24);
            cbZoom.TabIndex = 15;
            cbZoom.Text = "Enabled";
            cbZoom.UseVisualStyleBackColor = true;
            cbZoom.CheckedChanged += cbZoom_CheckedChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(cbDebugMode);
            tabPage4.Controls.Add(mmLog);
            tabPage4.Location = new System.Drawing.Point(4, 29);
            tabPage4.Margin = new Padding(4, 5, 4, 5);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(4, 5, 4, 5);
            tabPage4.Size = new System.Drawing.Size(498, 620);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Log";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // cbDebugMode
            // 
            cbDebugMode.AutoSize = true;
            cbDebugMode.Location = new System.Drawing.Point(14, 17);
            cbDebugMode.Margin = new Padding(4, 5, 4, 5);
            cbDebugMode.Name = "cbDebugMode";
            cbDebugMode.Size = new System.Drawing.Size(119, 24);
            cbDebugMode.TabIndex = 78;
            cbDebugMode.Text = "Debug mode";
            cbDebugMode.UseVisualStyleBackColor = true;
            // 
            // mmLog
            // 
            mmLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mmLog.Location = new System.Drawing.Point(14, 52);
            mmLog.Margin = new Padding(4, 5, 4, 5);
            mmLog.Multiline = true;
            mmLog.Name = "mmLog";
            mmLog.ScrollBars = ScrollBars.Vertical;
            mmLog.Size = new System.Drawing.Size(460, 550);
            mmLog.TabIndex = 77;
            // 
            // openFileDialog2
            // 
            openFileDialog2.Filter = "Pictures|*.bmp; *.jpg; *.jpeg; *.jpe; *.png; *.gif; *.tiff;|All files|*.*";
            // 
            // fontDialog1
            // 
            fontDialog1.Color = System.Drawing.Color.White;
            fontDialog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            fontDialog1.FontMustExist = true;
            fontDialog1.ShowColor = true;
            // 
            // btSaveScreenshot
            // 
            btSaveScreenshot.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btSaveScreenshot.Location = new System.Drawing.Point(188, 760);
            btSaveScreenshot.Margin = new Padding(4, 5, 4, 5);
            btSaveScreenshot.Name = "btSaveScreenshot";
            btSaveScreenshot.Size = new System.Drawing.Size(138, 35);
            btSaveScreenshot.TabIndex = 108;
            btSaveScreenshot.Text = "Save snapshot (S)";
            btSaveScreenshot.UseVisualStyleBackColor = true;
            btSaveScreenshot.Click += btSaveScreenshot_Click;
            // 
            // btResume
            // 
            btResume.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btResume.Location = new System.Drawing.Point(432, 681);
            btResume.Margin = new Padding(4, 5, 4, 5);
            btResume.Name = "btResume";
            btResume.Size = new System.Drawing.Size(74, 35);
            btResume.TabIndex = 107;
            btResume.Text = "Resume";
            btResume.UseVisualStyleBackColor = true;
            btResume.Click += btResume_Click;
            // 
            // btPause
            // 
            btPause.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btPause.Location = new System.Drawing.Point(350, 681);
            btPause.Margin = new Padding(4, 5, 4, 5);
            btPause.Name = "btPause";
            btPause.Size = new System.Drawing.Size(74, 35);
            btPause.TabIndex = 106;
            btPause.Text = "Pause";
            btPause.UseVisualStyleBackColor = true;
            btPause.Click += btPause_Click;
            // 
            // VideoView1
            // 
            VideoView1.BackColor = System.Drawing.Color.Black;
            VideoView1.Location = new System.Drawing.Point(553, 34);
            VideoView1.Margin = new Padding(4, 5, 4, 5);
            VideoView1.Name = "VideoView1";
            VideoView1.Size = new System.Drawing.Size(1215, 834);
            VideoView1.StatusOverlay = null;
            VideoView1.TabIndex = 109;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(830, 464);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(133, 20);
            label4.TabIndex = 121;
            label4.Text = "Video input device";
            // 
            // lbLastScreenCaptureStatus
            // 
            lbLastScreenCaptureStatus.AutoSize = true;
            lbLastScreenCaptureStatus.Location = new System.Drawing.Point(518, 942);
            lbLastScreenCaptureStatus.Name = "lbLastScreenCaptureStatus";
            lbLastScreenCaptureStatus.Size = new System.Drawing.Size(143, 20);
            lbLastScreenCaptureStatus.TabIndex = 122;
            lbLastScreenCaptureStatus.Text = "No screenshot taken";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1793, 960);
            Controls.Add(lbLastScreenCaptureStatus);
            Controls.Add(btStop);
            Controls.Add(btSaveScreenshot);
            Controls.Add(btStart);
            Controls.Add(label4);
            Controls.Add(VideoView1);
            Controls.Add(btResume);
            Controls.Add(tcMain);
            Controls.Add(btPause);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Simple Video Capture Demo - Video Capture SDK .Net";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            tcMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbDarkness).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbContrast).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbLightness).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSaturation).EndInit();
            tabZoom.ResumeLayout(false);
            tabZoom.PerformLayout();
            groupBox37.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        // In your form's constructor or Load event, add the KeyDown event handler

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                btEffZoomIn_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                btEffZoomOut_Click(sender, e);
            }
        }

        #endregion

        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabZoom;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbUseBestVideoInputFormat;
        private System.Windows.Forms.Button btVideoCaptureDeviceSettings;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbVideoInputFrameRate;
        private System.Windows.Forms.ComboBox cbVideoInputFormat;
        private System.Windows.Forms.ComboBox cbVideoInputDevice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbDebugMode;
        private System.Windows.Forms.TextBox mmLog;
        private System.Windows.Forms.Button btSaveScreenshot;
        private System.Windows.Forms.Button btResume;
        private System.Windows.Forms.Button btPause;
        private System.Windows.Forms.ComboBox cbOutputFormat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTextLogoAdd;
        private System.Windows.Forms.Button btLogoRemove;
        private System.Windows.Forms.Button btLogoEdit;
        private System.Windows.Forms.ListBox lbLogos;
        private System.Windows.Forms.Button btImageLogoAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label200;
        private System.Windows.Forms.Label label199;
        private System.Windows.Forms.Label label198;
        private System.Windows.Forms.TrackBar tbContrast;
        private System.Windows.Forms.TrackBar tbLightness;
        private System.Windows.Forms.TrackBar tbSaturation;
        private System.Windows.Forms.Label label201;
        private System.Windows.Forms.TrackBar tbDarkness;
        private System.Windows.Forms.CheckBox cbFlipY;
        private System.Windows.Forms.CheckBox cbFlipX;
        private System.Windows.Forms.CheckBox cbInvert;
        private System.Windows.Forms.CheckBox cbGreyscale;
        private System.Windows.Forms.CheckBox cbMergeTextLogos;
        private System.Windows.Forms.CheckBox cbMergeImageLogos;
        private VisioForge.Core.UI.WinForms.VideoView VideoView1;
        private System.Windows.Forms.CheckBox cbScrollingText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbLastScreenCaptureStatus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox37;
        private System.Windows.Forms.CheckBox cbZoom;
        private System.Windows.Forms.Button btEffZoomRight;
        private System.Windows.Forms.Button btEffZoomLeft;
        private System.Windows.Forms.Button btEffZoomOut;
        private System.Windows.Forms.Button btEffZoomIn;
        private System.Windows.Forms.Button btEffZoomDown;
        private System.Windows.Forms.Button btEffZoomUp;
        private Label label6;
        private Label label5;
    }
}

