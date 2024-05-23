using VisioForge.Core.Types;
using System;

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
            btStop = new System.Windows.Forms.Button();
            btStart = new System.Windows.Forms.Button();
            tcMain = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            label1 = new System.Windows.Forms.Label();
            cbUseBestVideoInputFormat = new System.Windows.Forms.CheckBox();
            btVideoCaptureDeviceSettings = new System.Windows.Forms.Button();
            label18 = new System.Windows.Forms.Label();
            cbVideoInputFrameRate = new System.Windows.Forms.ComboBox();
            cbVideoInputFormat = new System.Windows.Forms.ComboBox();
            cbVideoInputDevice = new System.Windows.Forms.ComboBox();
            label13 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label55 = new System.Windows.Forms.Label();
            tbAudioBalance = new System.Windows.Forms.TrackBar();
            label54 = new System.Windows.Forms.Label();
            tbAudioVolume = new System.Windows.Forms.TrackBar();
            cbRecordAudio = new System.Windows.Forms.CheckBox();
            cbAudioOutputDevice = new System.Windows.Forms.ComboBox();
            label15 = new System.Windows.Forms.Label();
            cbUseBestAudioInputFormat = new System.Windows.Forms.CheckBox();
            btAudioInputDeviceSettings = new System.Windows.Forms.Button();
            cbAudioInputLine = new System.Windows.Forms.ComboBox();
            cbAudioInputFormat = new System.Windows.Forms.ComboBox();
            cbAudioInputDevice = new System.Windows.Forms.ComboBox();
            label22 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            tabPage2 = new System.Windows.Forms.TabPage();
            btSelectOutput = new System.Windows.Forms.Button();
            edOutput = new System.Windows.Forms.TextBox();
            lbInfo = new System.Windows.Forms.Label();
            btOutputConfigure = new System.Windows.Forms.Button();
            cbOutputFormat = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            tabPage3 = new System.Windows.Forms.TabPage();
            cbScrollingText = new System.Windows.Forms.CheckBox();
            cbMergeTextLogos = new System.Windows.Forms.CheckBox();
            cbMergeImageLogos = new System.Windows.Forms.CheckBox();
            cbFlipY = new System.Windows.Forms.CheckBox();
            cbFlipX = new System.Windows.Forms.CheckBox();
            cbInvert = new System.Windows.Forms.CheckBox();
            cbGreyscale = new System.Windows.Forms.CheckBox();
            label201 = new System.Windows.Forms.Label();
            tbDarkness = new System.Windows.Forms.TrackBar();
            label200 = new System.Windows.Forms.Label();
            label199 = new System.Windows.Forms.Label();
            label198 = new System.Windows.Forms.Label();
            tbContrast = new System.Windows.Forms.TrackBar();
            tbLightness = new System.Windows.Forms.TrackBar();
            tbSaturation = new System.Windows.Forms.TrackBar();
            label3 = new System.Windows.Forms.Label();
            btTextLogoAdd = new System.Windows.Forms.Button();
            btLogoRemove = new System.Windows.Forms.Button();
            btLogoEdit = new System.Windows.Forms.Button();
            lbLogos = new System.Windows.Forms.ListBox();
            btImageLogoAdd = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            tabPage5 = new System.Windows.Forms.TabPage();
            label5 = new System.Windows.Forms.Label();
            tabControl18 = new System.Windows.Forms.TabControl();
            tabPage71 = new System.Windows.Forms.TabPage();
            label231 = new System.Windows.Forms.Label();
            label230 = new System.Windows.Forms.Label();
            tbAudAmplifyAmp = new System.Windows.Forms.TrackBar();
            label95 = new System.Windows.Forms.Label();
            cbAudAmplifyEnabled = new System.Windows.Forms.CheckBox();
            tabPage72 = new System.Windows.Forms.TabPage();
            btAudEqRefresh = new System.Windows.Forms.Button();
            cbAudEqualizerPreset = new System.Windows.Forms.ComboBox();
            label243 = new System.Windows.Forms.Label();
            label242 = new System.Windows.Forms.Label();
            label241 = new System.Windows.Forms.Label();
            label240 = new System.Windows.Forms.Label();
            label239 = new System.Windows.Forms.Label();
            label238 = new System.Windows.Forms.Label();
            label237 = new System.Windows.Forms.Label();
            label236 = new System.Windows.Forms.Label();
            label235 = new System.Windows.Forms.Label();
            label234 = new System.Windows.Forms.Label();
            label233 = new System.Windows.Forms.Label();
            label232 = new System.Windows.Forms.Label();
            tbAudEq9 = new System.Windows.Forms.TrackBar();
            tbAudEq8 = new System.Windows.Forms.TrackBar();
            tbAudEq7 = new System.Windows.Forms.TrackBar();
            tbAudEq6 = new System.Windows.Forms.TrackBar();
            tbAudEq5 = new System.Windows.Forms.TrackBar();
            tbAudEq4 = new System.Windows.Forms.TrackBar();
            tbAudEq3 = new System.Windows.Forms.TrackBar();
            tbAudEq2 = new System.Windows.Forms.TrackBar();
            tbAudEq1 = new System.Windows.Forms.TrackBar();
            tbAudEq0 = new System.Windows.Forms.TrackBar();
            cbAudEqualizerEnabled = new System.Windows.Forms.CheckBox();
            tabPage76 = new System.Windows.Forms.TabPage();
            tbAudTrueBass = new System.Windows.Forms.TrackBar();
            label254 = new System.Windows.Forms.Label();
            cbAudTrueBassEnabled = new System.Windows.Forms.CheckBox();
            tabPage4 = new System.Windows.Forms.TabPage();
            cbDebugMode = new System.Windows.Forms.CheckBox();
            mmLog = new System.Windows.Forms.TextBox();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            fontDialog1 = new System.Windows.Forms.FontDialog();
            llVideoTutorials = new System.Windows.Forms.LinkLabel();
            label34 = new System.Windows.Forms.Label();
            lbTimestamp = new System.Windows.Forms.Label();
            rbCapture = new System.Windows.Forms.RadioButton();
            rbPreview = new System.Windows.Forms.RadioButton();
            btSaveScreenshot = new System.Windows.Forms.Button();
            btResume = new System.Windows.Forms.Button();
            btPause = new System.Windows.Forms.Button();
            VideoView1 = new VisioForge.Core.UI.WinForms.VideoView();
            tcMain.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbAudioBalance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAudioVolume).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbDarkness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbContrast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbLightness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSaturation).BeginInit();
            tabPage5.SuspendLayout();
            tabControl18.SuspendLayout();
            tabPage71.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbAudAmplifyAmp).BeginInit();
            tabPage72.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbAudEq9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAudEq8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAudEq7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAudEq6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAudEq5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAudEq4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAudEq3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAudEq2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAudEq1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAudEq0).BeginInit();
            tabPage76.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbAudTrueBass).BeginInit();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // btStop
            // 
            btStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            btStop.Location = new System.Drawing.Point(1271, 899);
            btStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btStop.Name = "btStop";
            btStop.Size = new System.Drawing.Size(82, 35);
            btStop.TabIndex = 54;
            btStop.Text = "Stop";
            btStop.UseVisualStyleBackColor = true;
            btStop.Click += btStop_Click;
            // 
            // btStart
            // 
            btStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            btStart.Location = new System.Drawing.Point(1181, 899);
            btStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btStart.Name = "btStart";
            btStart.Size = new System.Drawing.Size(82, 35);
            btStart.TabIndex = 53;
            btStart.Text = "Start";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // tcMain
            // 
            tcMain.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tcMain.Controls.Add(tabPage1);
            tcMain.Controls.Add(tabPage2);
            tcMain.Controls.Add(tabPage3);
            tcMain.Controls.Add(tabPage5);
            tcMain.Controls.Add(tabPage4);
            tcMain.Location = new System.Drawing.Point(4, 5);
            tcMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new System.Drawing.Size(504, 930);
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
            tabPage1.Controls.Add(label55);
            tabPage1.Controls.Add(tbAudioBalance);
            tabPage1.Controls.Add(label54);
            tabPage1.Controls.Add(tbAudioVolume);
            tabPage1.Controls.Add(cbRecordAudio);
            tabPage1.Controls.Add(cbAudioOutputDevice);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(cbUseBestAudioInputFormat);
            tabPage1.Controls.Add(btAudioInputDeviceSettings);
            tabPage1.Controls.Add(cbAudioInputLine);
            tabPage1.Controls.Add(cbAudioInputFormat);
            tabPage1.Controls.Add(cbAudioInputDevice);
            tabPage1.Controls.Add(label22);
            tabPage1.Controls.Add(label23);
            tabPage1.Controls.Add(label25);
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabPage1.Size = new System.Drawing.Size(496, 897);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Devices";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(452, 142);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 20);
            label1.TabIndex = 128;
            label1.Text = "fps";
            // 
            // cbUseBestVideoInputFormat
            // 
            cbUseBestVideoInputFormat.AutoSize = true;
            cbUseBestVideoInputFormat.Location = new System.Drawing.Point(250, 110);
            cbUseBestVideoInputFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            btVideoCaptureDeviceSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(80, 20);
            label18.TabIndex = 125;
            label18.Text = "Frame rate";
            // 
            // cbVideoInputFrameRate
            // 
            cbVideoInputFrameRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbVideoInputFrameRate.FormattingEnabled = true;
            cbVideoInputFrameRate.Location = new System.Drawing.Point(358, 137);
            cbVideoInputFrameRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbVideoInputFrameRate.Name = "cbVideoInputFrameRate";
            cbVideoInputFrameRate.Size = new System.Drawing.Size(86, 28);
            cbVideoInputFrameRate.TabIndex = 124;
            // 
            // cbVideoInputFormat
            // 
            cbVideoInputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbVideoInputFormat.FormattingEnabled = true;
            cbVideoInputFormat.Location = new System.Drawing.Point(12, 137);
            cbVideoInputFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbVideoInputFormat.Name = "cbVideoInputFormat";
            cbVideoInputFormat.Size = new System.Drawing.Size(328, 28);
            cbVideoInputFormat.TabIndex = 123;
            cbVideoInputFormat.SelectedIndexChanged += cbVideoInputFormat_SelectedIndexChanged;
            // 
            // cbVideoInputDevice
            // 
            cbVideoInputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbVideoInputDevice.FormattingEnabled = true;
            cbVideoInputDevice.Location = new System.Drawing.Point(12, 55);
            cbVideoInputDevice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbVideoInputDevice.Name = "cbVideoInputDevice";
            cbVideoInputDevice.Size = new System.Drawing.Size(328, 28);
            cbVideoInputDevice.TabIndex = 122;
            cbVideoInputDevice.SelectedIndexChanged += cbVideoInputDevice_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(6, 112);
            label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(135, 20);
            label13.TabIndex = 121;
            label13.Text = "Video input format";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(8, 30);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(133, 20);
            label11.TabIndex = 120;
            label11.Text = "Video input device";
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Location = new System.Drawing.Point(264, 550);
            label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label55.Name = "label55";
            label55.Size = new System.Drawing.Size(61, 20);
            label55.TabIndex = 90;
            label55.Text = "Balance";
            // 
            // tbAudioBalance
            // 
            tbAudioBalance.BackColor = System.Drawing.SystemColors.Window;
            tbAudioBalance.Location = new System.Drawing.Point(332, 543);
            tbAudioBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbAudioBalance.Maximum = 100;
            tbAudioBalance.Minimum = -100;
            tbAudioBalance.Name = "tbAudioBalance";
            tbAudioBalance.Size = new System.Drawing.Size(152, 56);
            tbAudioBalance.TabIndex = 89;
            tbAudioBalance.TickFrequency = 5;
            tbAudioBalance.TickStyle = System.Windows.Forms.TickStyle.None;
            tbAudioBalance.Scroll += tbAudioBalance_Scroll;
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.Location = new System.Drawing.Point(10, 550);
            label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label54.Name = "label54";
            label54.Size = new System.Drawing.Size(59, 20);
            label54.TabIndex = 88;
            label54.Text = "Volume";
            // 
            // tbAudioVolume
            // 
            tbAudioVolume.BackColor = System.Drawing.SystemColors.Window;
            tbAudioVolume.Location = new System.Drawing.Point(72, 543);
            tbAudioVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbAudioVolume.Maximum = 100;
            tbAudioVolume.Minimum = 20;
            tbAudioVolume.Name = "tbAudioVolume";
            tbAudioVolume.Size = new System.Drawing.Size(154, 56);
            tbAudioVolume.TabIndex = 87;
            tbAudioVolume.TickFrequency = 10;
            tbAudioVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            tbAudioVolume.Value = 80;
            tbAudioVolume.Scroll += tbAudioVolume_Scroll;
            // 
            // cbRecordAudio
            // 
            cbRecordAudio.AutoSize = true;
            cbRecordAudio.Checked = true;
            cbRecordAudio.CheckState = System.Windows.Forms.CheckState.Checked;
            cbRecordAudio.Location = new System.Drawing.Point(338, 475);
            cbRecordAudio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbRecordAudio.Name = "cbRecordAudio";
            cbRecordAudio.Size = new System.Drawing.Size(153, 24);
            cbRecordAudio.TabIndex = 86;
            cbRecordAudio.Text = "Play/Record audio";
            cbRecordAudio.UseVisualStyleBackColor = true;
            // 
            // cbAudioOutputDevice
            // 
            cbAudioOutputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbAudioOutputDevice.FormattingEnabled = true;
            cbAudioOutputDevice.Location = new System.Drawing.Point(12, 502);
            cbAudioOutputDevice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbAudioOutputDevice.Name = "cbAudioOutputDevice";
            cbAudioOutputDevice.Size = new System.Drawing.Size(470, 28);
            cbAudioOutputDevice.TabIndex = 85;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(8, 477);
            label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(144, 20);
            label15.TabIndex = 84;
            label15.Text = "Audio output device";
            // 
            // cbUseBestAudioInputFormat
            // 
            cbUseBestAudioInputFormat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cbUseBestAudioInputFormat.AutoSize = true;
            cbUseBestAudioInputFormat.Location = new System.Drawing.Point(397, 350);
            cbUseBestAudioInputFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbUseBestAudioInputFormat.Name = "cbUseBestAudioInputFormat";
            cbUseBestAudioInputFormat.Size = new System.Drawing.Size(87, 24);
            cbUseBestAudioInputFormat.TabIndex = 83;
            cbUseBestAudioInputFormat.Text = "Use best";
            cbUseBestAudioInputFormat.UseVisualStyleBackColor = true;
            cbUseBestAudioInputFormat.CheckedChanged += cbUseBestAudioInputFormat_CheckedChanged;
            // 
            // btAudioInputDeviceSettings
            // 
            btAudioInputDeviceSettings.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btAudioInputDeviceSettings.Location = new System.Drawing.Point(382, 288);
            btAudioInputDeviceSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btAudioInputDeviceSettings.Name = "btAudioInputDeviceSettings";
            btAudioInputDeviceSettings.Size = new System.Drawing.Size(102, 35);
            btAudioInputDeviceSettings.TabIndex = 82;
            btAudioInputDeviceSettings.Text = "Settings";
            btAudioInputDeviceSettings.UseVisualStyleBackColor = true;
            btAudioInputDeviceSettings.Click += btAudioInputDeviceSettings_Click;
            // 
            // cbAudioInputLine
            // 
            cbAudioInputLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbAudioInputLine.FormattingEnabled = true;
            cbAudioInputLine.Location = new System.Drawing.Point(10, 377);
            cbAudioInputLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbAudioInputLine.Name = "cbAudioInputLine";
            cbAudioInputLine.Size = new System.Drawing.Size(214, 28);
            cbAudioInputLine.TabIndex = 81;
            // 
            // cbAudioInputFormat
            // 
            cbAudioInputFormat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbAudioInputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbAudioInputFormat.FormattingEnabled = true;
            cbAudioInputFormat.Location = new System.Drawing.Point(244, 377);
            cbAudioInputFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbAudioInputFormat.Name = "cbAudioInputFormat";
            cbAudioInputFormat.Size = new System.Drawing.Size(238, 28);
            cbAudioInputFormat.TabIndex = 80;
            // 
            // cbAudioInputDevice
            // 
            cbAudioInputDevice.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbAudioInputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbAudioInputDevice.FormattingEnabled = true;
            cbAudioInputDevice.Location = new System.Drawing.Point(10, 290);
            cbAudioInputDevice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbAudioInputDevice.Name = "cbAudioInputDevice";
            cbAudioInputDevice.Size = new System.Drawing.Size(362, 28);
            cbAudioInputDevice.TabIndex = 79;
            cbAudioInputDevice.SelectedIndexChanged += cbAudioInputDevice_SelectedIndexChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(8, 352);
            label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(115, 20);
            label22.TabIndex = 78;
            label22.Text = "Audio input line";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(8, 266);
            label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(134, 20);
            label23.TabIndex = 77;
            label23.Text = "Audio input device";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(240, 350);
            label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(92, 20);
            label25.TabIndex = 76;
            label25.Text = "Input format";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btSelectOutput);
            tabPage2.Controls.Add(edOutput);
            tabPage2.Controls.Add(lbInfo);
            tabPage2.Controls.Add(btOutputConfigure);
            tabPage2.Controls.Add(cbOutputFormat);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabPage2.Size = new System.Drawing.Size(496, 897);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Output";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btSelectOutput
            // 
            btSelectOutput.Location = new System.Drawing.Point(454, 245);
            btSelectOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btSelectOutput.Name = "btSelectOutput";
            btSelectOutput.Size = new System.Drawing.Size(32, 35);
            btSelectOutput.TabIndex = 126;
            btSelectOutput.Text = "...";
            btSelectOutput.UseVisualStyleBackColor = true;
            btSelectOutput.Click += btSelectOutput_Click;
            // 
            // edOutput
            // 
            edOutput.Location = new System.Drawing.Point(22, 248);
            edOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            edOutput.Name = "edOutput";
            edOutput.Size = new System.Drawing.Size(422, 27);
            edOutput.TabIndex = 125;
            edOutput.Text = "c:\\capture.avi";
            // 
            // lbInfo
            // 
            lbInfo.AutoSize = true;
            lbInfo.Location = new System.Drawing.Point(18, 94);
            lbInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new System.Drawing.Size(377, 20);
            lbInfo.TabIndex = 124;
            lbInfo.Text = "You can use dialog or code to configure format settings";
            // 
            // btOutputConfigure
            // 
            btOutputConfigure.Location = new System.Drawing.Point(22, 118);
            btOutputConfigure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btOutputConfigure.Name = "btOutputConfigure";
            btOutputConfigure.Size = new System.Drawing.Size(100, 35);
            btOutputConfigure.TabIndex = 123;
            btOutputConfigure.Text = "Configure";
            btOutputConfigure.UseVisualStyleBackColor = true;
            btOutputConfigure.Click += btOutputConfigure_Click;
            // 
            // cbOutputFormat
            // 
            cbOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbOutputFormat.FormattingEnabled = true;
            cbOutputFormat.Items.AddRange(new object[] { "AVI", "WMV (Windows Media Video)", "MP4 (CPU)", "MP4 (GPU: Intel, Nvidia, AMD/ATI)", "Animated GIF", "MPEG-TS", "MOV" });
            cbOutputFormat.Location = new System.Drawing.Point(22, 50);
            cbOutputFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbOutputFormat.Name = "cbOutputFormat";
            cbOutputFormat.Size = new System.Drawing.Size(462, 28);
            cbOutputFormat.TabIndex = 122;
            cbOutputFormat.SelectedIndexChanged += cbOutputFormat_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(18, 223);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(73, 20);
            label4.TabIndex = 121;
            label4.Text = "File name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(18, 25);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabPage3.Size = new System.Drawing.Size(496, 897);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Video effects";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbScrollingText
            // 
            cbScrollingText.AutoSize = true;
            cbScrollingText.Location = new System.Drawing.Point(70, 535);
            cbScrollingText.Margin = new System.Windows.Forms.Padding(2);
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
            cbMergeTextLogos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            cbMergeImageLogos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            cbFlipY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            cbFlipX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            cbInvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            cbInvert.Location = new System.Drawing.Point(176, 505);
            cbInvert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            cbGreyscale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            label201.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label201.Name = "label201";
            label201.Size = new System.Drawing.Size(68, 20);
            label201.TabIndex = 81;
            label201.Text = "Darkness";
            // 
            // tbDarkness
            // 
            tbDarkness.BackColor = System.Drawing.SystemColors.Window;
            tbDarkness.Location = new System.Drawing.Point(246, 426);
            tbDarkness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            label200.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label200.Name = "label200";
            label200.Size = new System.Drawing.Size(64, 20);
            label200.TabIndex = 76;
            label200.Text = "Contrast";
            // 
            // label199
            // 
            label199.AutoSize = true;
            label199.Location = new System.Drawing.Point(246, 317);
            label199.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label199.Name = "label199";
            label199.Size = new System.Drawing.Size(77, 20);
            label199.TabIndex = 75;
            label199.Text = "Saturation";
            // 
            // label198
            // 
            label198.AutoSize = true;
            label198.Location = new System.Drawing.Point(66, 317);
            label198.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label198.Name = "label198";
            label198.Size = new System.Drawing.Size(70, 20);
            label198.TabIndex = 74;
            label198.Text = "Lightness";
            // 
            // tbContrast
            // 
            tbContrast.BackColor = System.Drawing.SystemColors.Window;
            tbContrast.Location = new System.Drawing.Point(62, 426);
            tbContrast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            tbLightness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            tbSaturation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(133, 20);
            label3.TabIndex = 69;
            label3.Text = "Text / image logos";
            // 
            // btTextLogoAdd
            // 
            btTextLogoAdd.Location = new System.Drawing.Point(156, 194);
            btTextLogoAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            btLogoRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            btLogoEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            lbLogos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            lbLogos.Name = "lbLogos";
            lbLogos.Size = new System.Drawing.Size(458, 144);
            lbLogos.TabIndex = 65;
            // 
            // btImageLogoAdd
            // 
            btImageLogoAdd.Location = new System.Drawing.Point(16, 194);
            btImageLogoAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(338, 20);
            label2.TabIndex = 63;
            label2.Text = "More effects and settings available in Main Demo";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label5);
            tabPage5.Controls.Add(tabControl18);
            tabPage5.Location = new System.Drawing.Point(4, 29);
            tabPage5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabPage5.Size = new System.Drawing.Size(496, 897);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Audio effects";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(80, 566);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(338, 20);
            label5.TabIndex = 64;
            label5.Text = "More effects and settings available in Main Demo";
            // 
            // tabControl18
            // 
            tabControl18.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl18.Controls.Add(tabPage71);
            tabControl18.Controls.Add(tabPage72);
            tabControl18.Controls.Add(tabPage76);
            tabControl18.Location = new System.Drawing.Point(10, 10);
            tabControl18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabControl18.Name = "tabControl18";
            tabControl18.SelectedIndex = 0;
            tabControl18.Size = new System.Drawing.Size(476, 534);
            tabControl18.TabIndex = 2;
            // 
            // tabPage71
            // 
            tabPage71.Controls.Add(label231);
            tabPage71.Controls.Add(label230);
            tabPage71.Controls.Add(tbAudAmplifyAmp);
            tabPage71.Controls.Add(label95);
            tabPage71.Controls.Add(cbAudAmplifyEnabled);
            tabPage71.Location = new System.Drawing.Point(4, 29);
            tabPage71.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabPage71.Name = "tabPage71";
            tabPage71.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabPage71.Size = new System.Drawing.Size(468, 501);
            tabPage71.TabIndex = 0;
            tabPage71.Text = "Amplify";
            tabPage71.UseVisualStyleBackColor = true;
            // 
            // label231
            // 
            label231.AutoSize = true;
            label231.Location = new System.Drawing.Point(326, 82);
            label231.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label231.Name = "label231";
            label231.Size = new System.Drawing.Size(45, 20);
            label231.TabIndex = 5;
            label231.Text = "400%";
            // 
            // label230
            // 
            label230.AutoSize = true;
            label230.Location = new System.Drawing.Point(100, 82);
            label230.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label230.Name = "label230";
            label230.Size = new System.Drawing.Size(45, 20);
            label230.TabIndex = 4;
            label230.Text = "100%";
            // 
            // tbAudAmplifyAmp
            // 
            tbAudAmplifyAmp.BackColor = System.Drawing.SystemColors.Window;
            tbAudAmplifyAmp.Location = new System.Drawing.Point(22, 106);
            tbAudAmplifyAmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbAudAmplifyAmp.Maximum = 4000;
            tbAudAmplifyAmp.Name = "tbAudAmplifyAmp";
            tbAudAmplifyAmp.Size = new System.Drawing.Size(348, 56);
            tbAudAmplifyAmp.TabIndex = 3;
            tbAudAmplifyAmp.TickFrequency = 50;
            tbAudAmplifyAmp.Value = 1000;
            tbAudAmplifyAmp.Scroll += tbAudAmplifyAmp_Scroll;
            // 
            // label95
            // 
            label95.AutoSize = true;
            label95.Location = new System.Drawing.Point(18, 82);
            label95.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label95.Name = "label95";
            label95.Size = new System.Drawing.Size(59, 20);
            label95.TabIndex = 2;
            label95.Text = "Volume";
            // 
            // cbAudAmplifyEnabled
            // 
            cbAudAmplifyEnabled.AutoSize = true;
            cbAudAmplifyEnabled.Location = new System.Drawing.Point(22, 25);
            cbAudAmplifyEnabled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbAudAmplifyEnabled.Name = "cbAudAmplifyEnabled";
            cbAudAmplifyEnabled.Size = new System.Drawing.Size(85, 24);
            cbAudAmplifyEnabled.TabIndex = 1;
            cbAudAmplifyEnabled.Text = "Enabled";
            cbAudAmplifyEnabled.UseVisualStyleBackColor = true;
            cbAudAmplifyEnabled.CheckedChanged += cbAudAmplifyEnabled_CheckedChanged;
            // 
            // tabPage72
            // 
            tabPage72.Controls.Add(btAudEqRefresh);
            tabPage72.Controls.Add(cbAudEqualizerPreset);
            tabPage72.Controls.Add(label243);
            tabPage72.Controls.Add(label242);
            tabPage72.Controls.Add(label241);
            tabPage72.Controls.Add(label240);
            tabPage72.Controls.Add(label239);
            tabPage72.Controls.Add(label238);
            tabPage72.Controls.Add(label237);
            tabPage72.Controls.Add(label236);
            tabPage72.Controls.Add(label235);
            tabPage72.Controls.Add(label234);
            tabPage72.Controls.Add(label233);
            tabPage72.Controls.Add(label232);
            tabPage72.Controls.Add(tbAudEq9);
            tabPage72.Controls.Add(tbAudEq8);
            tabPage72.Controls.Add(tbAudEq7);
            tabPage72.Controls.Add(tbAudEq6);
            tabPage72.Controls.Add(tbAudEq5);
            tabPage72.Controls.Add(tbAudEq4);
            tabPage72.Controls.Add(tbAudEq3);
            tabPage72.Controls.Add(tbAudEq2);
            tabPage72.Controls.Add(tbAudEq1);
            tabPage72.Controls.Add(tbAudEq0);
            tabPage72.Controls.Add(cbAudEqualizerEnabled);
            tabPage72.Location = new System.Drawing.Point(4, 29);
            tabPage72.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabPage72.Name = "tabPage72";
            tabPage72.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabPage72.Size = new System.Drawing.Size(468, 501);
            tabPage72.TabIndex = 1;
            tabPage72.Text = "Equalizer";
            tabPage72.UseVisualStyleBackColor = true;
            // 
            // btAudEqRefresh
            // 
            btAudEqRefresh.Location = new System.Drawing.Point(358, 426);
            btAudEqRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btAudEqRefresh.Name = "btAudEqRefresh";
            btAudEqRefresh.Size = new System.Drawing.Size(100, 35);
            btAudEqRefresh.TabIndex = 26;
            btAudEqRefresh.Text = "Refresh";
            btAudEqRefresh.UseVisualStyleBackColor = true;
            btAudEqRefresh.Click += btAudEqRefresh_Click;
            // 
            // cbAudEqualizerPreset
            // 
            cbAudEqualizerPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbAudEqualizerPreset.FormattingEnabled = true;
            cbAudEqualizerPreset.Location = new System.Drawing.Point(82, 430);
            cbAudEqualizerPreset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbAudEqualizerPreset.Name = "cbAudEqualizerPreset";
            cbAudEqualizerPreset.Size = new System.Drawing.Size(266, 28);
            cbAudEqualizerPreset.TabIndex = 25;
            cbAudEqualizerPreset.SelectedIndexChanged += cbAudEqualizerPreset_SelectedIndexChanged;
            // 
            // label243
            // 
            label243.AutoSize = true;
            label243.Location = new System.Drawing.Point(18, 434);
            label243.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label243.Name = "label243";
            label243.Size = new System.Drawing.Size(49, 20);
            label243.TabIndex = 24;
            label243.Text = "Preset";
            // 
            // label242
            // 
            label242.AutoSize = true;
            label242.Location = new System.Drawing.Point(364, 365);
            label242.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label242.Name = "label242";
            label242.Size = new System.Drawing.Size(34, 20);
            label242.TabIndex = 23;
            label242.Text = "16K";
            // 
            // label241
            // 
            label241.AutoSize = true;
            label241.Location = new System.Drawing.Point(324, 365);
            label241.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label241.Name = "label241";
            label241.Size = new System.Drawing.Size(34, 20);
            label241.TabIndex = 22;
            label241.Text = "14K";
            // 
            // label240
            // 
            label240.AutoSize = true;
            label240.Location = new System.Drawing.Point(284, 365);
            label240.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label240.Name = "label240";
            label240.Size = new System.Drawing.Size(34, 20);
            label240.TabIndex = 21;
            label240.Text = "12K";
            // 
            // label239
            // 
            label239.AutoSize = true;
            label239.Location = new System.Drawing.Point(248, 365);
            label239.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label239.Name = "label239";
            label239.Size = new System.Drawing.Size(26, 20);
            label239.TabIndex = 20;
            label239.Text = "6K";
            // 
            // label238
            // 
            label238.AutoSize = true;
            label238.Location = new System.Drawing.Point(208, 365);
            label238.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label238.Name = "label238";
            label238.Size = new System.Drawing.Size(26, 20);
            label238.TabIndex = 19;
            label238.Text = "3K";
            // 
            // label237
            // 
            label237.AutoSize = true;
            label237.Location = new System.Drawing.Point(172, 365);
            label237.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label237.Name = "label237";
            label237.Size = new System.Drawing.Size(26, 20);
            label237.TabIndex = 18;
            label237.Text = "1K";
            // 
            // label236
            // 
            label236.AutoSize = true;
            label236.Location = new System.Drawing.Point(132, 365);
            label236.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label236.Name = "label236";
            label236.Size = new System.Drawing.Size(33, 20);
            label236.TabIndex = 17;
            label236.Text = "600";
            // 
            // label235
            // 
            label235.AutoSize = true;
            label235.Location = new System.Drawing.Point(92, 365);
            label235.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label235.Name = "label235";
            label235.Size = new System.Drawing.Size(33, 20);
            label235.TabIndex = 16;
            label235.Text = "310";
            // 
            // label234
            // 
            label234.AutoSize = true;
            label234.Location = new System.Drawing.Point(52, 365);
            label234.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label234.Name = "label234";
            label234.Size = new System.Drawing.Size(33, 20);
            label234.TabIndex = 15;
            label234.Text = "170";
            // 
            // label233
            // 
            label233.AutoSize = true;
            label233.Location = new System.Drawing.Point(18, 365);
            label233.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label233.Name = "label233";
            label233.Size = new System.Drawing.Size(25, 20);
            label233.TabIndex = 14;
            label233.Text = "60";
            // 
            // label232
            // 
            label232.AutoSize = true;
            label232.Location = new System.Drawing.Point(208, 57);
            label232.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label232.Name = "label232";
            label232.Size = new System.Drawing.Size(17, 20);
            label232.TabIndex = 13;
            label232.Text = "0";
            // 
            // tbAudEq9
            // 
            tbAudEq9.BackColor = System.Drawing.SystemColors.Window;
            tbAudEq9.Location = new System.Drawing.Point(368, 82);
            tbAudEq9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbAudEq9.Maximum = 100;
            tbAudEq9.Minimum = -100;
            tbAudEq9.Name = "tbAudEq9";
            tbAudEq9.Orientation = System.Windows.Forms.Orientation.Vertical;
            tbAudEq9.Size = new System.Drawing.Size(56, 278);
            tbAudEq9.TabIndex = 12;
            tbAudEq9.TickStyle = System.Windows.Forms.TickStyle.None;
            tbAudEq9.Scroll += tbAudEq9_Scroll;
            // 
            // tbAudEq8
            // 
            tbAudEq8.BackColor = System.Drawing.SystemColors.Window;
            tbAudEq8.Location = new System.Drawing.Point(330, 82);
            tbAudEq8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbAudEq8.Maximum = 100;
            tbAudEq8.Minimum = -100;
            tbAudEq8.Name = "tbAudEq8";
            tbAudEq8.Orientation = System.Windows.Forms.Orientation.Vertical;
            tbAudEq8.Size = new System.Drawing.Size(56, 278);
            tbAudEq8.TabIndex = 11;
            tbAudEq8.TickStyle = System.Windows.Forms.TickStyle.None;
            tbAudEq8.Scroll += tbAudEq8_Scroll;
            // 
            // tbAudEq7
            // 
            tbAudEq7.BackColor = System.Drawing.SystemColors.Window;
            tbAudEq7.Location = new System.Drawing.Point(290, 82);
            tbAudEq7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbAudEq7.Maximum = 100;
            tbAudEq7.Minimum = -100;
            tbAudEq7.Name = "tbAudEq7";
            tbAudEq7.Orientation = System.Windows.Forms.Orientation.Vertical;
            tbAudEq7.Size = new System.Drawing.Size(56, 278);
            tbAudEq7.TabIndex = 10;
            tbAudEq7.TickStyle = System.Windows.Forms.TickStyle.None;
            tbAudEq7.Scroll += tbAudEq7_Scroll;
            // 
            // tbAudEq6
            // 
            tbAudEq6.BackColor = System.Drawing.SystemColors.Window;
            tbAudEq6.Location = new System.Drawing.Point(250, 82);
            tbAudEq6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbAudEq6.Maximum = 100;
            tbAudEq6.Minimum = -100;
            tbAudEq6.Name = "tbAudEq6";
            tbAudEq6.Orientation = System.Windows.Forms.Orientation.Vertical;
            tbAudEq6.Size = new System.Drawing.Size(56, 278);
            tbAudEq6.TabIndex = 9;
            tbAudEq6.TickStyle = System.Windows.Forms.TickStyle.None;
            tbAudEq6.Scroll += tbAudEq6_Scroll;
            // 
            // tbAudEq5
            // 
            tbAudEq5.BackColor = System.Drawing.SystemColors.Window;
            tbAudEq5.Location = new System.Drawing.Point(212, 82);
            tbAudEq5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbAudEq5.Maximum = 100;
            tbAudEq5.Minimum = -100;
            tbAudEq5.Name = "tbAudEq5";
            tbAudEq5.Orientation = System.Windows.Forms.Orientation.Vertical;
            tbAudEq5.Size = new System.Drawing.Size(56, 278);
            tbAudEq5.TabIndex = 8;
            tbAudEq5.TickStyle = System.Windows.Forms.TickStyle.None;
            tbAudEq5.Scroll += tbAudEq5_Scroll;
            // 
            // tbAudEq4
            // 
            tbAudEq4.BackColor = System.Drawing.SystemColors.Window;
            tbAudEq4.Location = new System.Drawing.Point(174, 82);
            tbAudEq4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbAudEq4.Maximum = 100;
            tbAudEq4.Minimum = -100;
            tbAudEq4.Name = "tbAudEq4";
            tbAudEq4.Orientation = System.Windows.Forms.Orientation.Vertical;
            tbAudEq4.Size = new System.Drawing.Size(56, 278);
            tbAudEq4.TabIndex = 7;
            tbAudEq4.TickStyle = System.Windows.Forms.TickStyle.None;
            tbAudEq4.Scroll += tbAudEq4_Scroll;
            // 
            // tbAudEq3
            // 
            tbAudEq3.BackColor = System.Drawing.SystemColors.Window;
            tbAudEq3.Location = new System.Drawing.Point(136, 82);
            tbAudEq3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbAudEq3.Maximum = 100;
            tbAudEq3.Minimum = -100;
            tbAudEq3.Name = "tbAudEq3";
            tbAudEq3.Orientation = System.Windows.Forms.Orientation.Vertical;
            tbAudEq3.Size = new System.Drawing.Size(56, 278);
            tbAudEq3.TabIndex = 6;
            tbAudEq3.TickStyle = System.Windows.Forms.TickStyle.None;
            tbAudEq3.Scroll += tbAudEq3_Scroll;
            // 
            // tbAudEq2
            // 
            tbAudEq2.BackColor = System.Drawing.SystemColors.Window;
            tbAudEq2.Location = new System.Drawing.Point(98, 82);
            tbAudEq2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbAudEq2.Maximum = 100;
            tbAudEq2.Minimum = -100;
            tbAudEq2.Name = "tbAudEq2";
            tbAudEq2.Orientation = System.Windows.Forms.Orientation.Vertical;
            tbAudEq2.Size = new System.Drawing.Size(56, 278);
            tbAudEq2.TabIndex = 5;
            tbAudEq2.TickStyle = System.Windows.Forms.TickStyle.None;
            tbAudEq2.Scroll += tbAudEq2_Scroll;
            // 
            // tbAudEq1
            // 
            tbAudEq1.BackColor = System.Drawing.SystemColors.Window;
            tbAudEq1.Location = new System.Drawing.Point(58, 82);
            tbAudEq1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbAudEq1.Maximum = 100;
            tbAudEq1.Minimum = -100;
            tbAudEq1.Name = "tbAudEq1";
            tbAudEq1.Orientation = System.Windows.Forms.Orientation.Vertical;
            tbAudEq1.Size = new System.Drawing.Size(56, 278);
            tbAudEq1.TabIndex = 4;
            tbAudEq1.TickStyle = System.Windows.Forms.TickStyle.None;
            tbAudEq1.Scroll += tbAudEq1_Scroll;
            // 
            // tbAudEq0
            // 
            tbAudEq0.BackColor = System.Drawing.SystemColors.Window;
            tbAudEq0.Location = new System.Drawing.Point(22, 82);
            tbAudEq0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbAudEq0.Maximum = 100;
            tbAudEq0.Minimum = -100;
            tbAudEq0.Name = "tbAudEq0";
            tbAudEq0.Orientation = System.Windows.Forms.Orientation.Vertical;
            tbAudEq0.Size = new System.Drawing.Size(56, 278);
            tbAudEq0.TabIndex = 3;
            tbAudEq0.TickStyle = System.Windows.Forms.TickStyle.None;
            tbAudEq0.Scroll += tbAudEq0_Scroll;
            // 
            // cbAudEqualizerEnabled
            // 
            cbAudEqualizerEnabled.AutoSize = true;
            cbAudEqualizerEnabled.Location = new System.Drawing.Point(22, 25);
            cbAudEqualizerEnabled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbAudEqualizerEnabled.Name = "cbAudEqualizerEnabled";
            cbAudEqualizerEnabled.Size = new System.Drawing.Size(85, 24);
            cbAudEqualizerEnabled.TabIndex = 2;
            cbAudEqualizerEnabled.Text = "Enabled";
            cbAudEqualizerEnabled.UseVisualStyleBackColor = true;
            cbAudEqualizerEnabled.CheckedChanged += cbAudEqualizerEnabled_CheckedChanged;
            // 
            // tabPage76
            // 
            tabPage76.Controls.Add(tbAudTrueBass);
            tabPage76.Controls.Add(label254);
            tabPage76.Controls.Add(cbAudTrueBassEnabled);
            tabPage76.Location = new System.Drawing.Point(4, 29);
            tabPage76.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabPage76.Name = "tabPage76";
            tabPage76.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabPage76.Size = new System.Drawing.Size(468, 501);
            tabPage76.TabIndex = 5;
            tabPage76.Text = "True bass";
            tabPage76.UseVisualStyleBackColor = true;
            // 
            // tbAudTrueBass
            // 
            tbAudTrueBass.BackColor = System.Drawing.SystemColors.Window;
            tbAudTrueBass.Location = new System.Drawing.Point(22, 106);
            tbAudTrueBass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbAudTrueBass.Maximum = 10000;
            tbAudTrueBass.Name = "tbAudTrueBass";
            tbAudTrueBass.Size = new System.Drawing.Size(348, 56);
            tbAudTrueBass.TabIndex = 21;
            tbAudTrueBass.TickFrequency = 250;
            tbAudTrueBass.Scroll += tbAudTrueBass_Scroll;
            // 
            // label254
            // 
            label254.AutoSize = true;
            label254.Location = new System.Drawing.Point(18, 82);
            label254.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label254.Name = "label254";
            label254.Size = new System.Drawing.Size(59, 20);
            label254.TabIndex = 20;
            label254.Text = "Volume";
            // 
            // cbAudTrueBassEnabled
            // 
            cbAudTrueBassEnabled.AutoSize = true;
            cbAudTrueBassEnabled.Location = new System.Drawing.Point(22, 25);
            cbAudTrueBassEnabled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbAudTrueBassEnabled.Name = "cbAudTrueBassEnabled";
            cbAudTrueBassEnabled.Size = new System.Drawing.Size(85, 24);
            cbAudTrueBassEnabled.TabIndex = 2;
            cbAudTrueBassEnabled.Text = "Enabled";
            cbAudTrueBassEnabled.UseVisualStyleBackColor = true;
            cbAudTrueBassEnabled.CheckedChanged += cbAudTrueBassEnabled_CheckedChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(cbDebugMode);
            tabPage4.Controls.Add(mmLog);
            tabPage4.Location = new System.Drawing.Point(4, 29);
            tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabPage4.Size = new System.Drawing.Size(496, 897);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Log";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // cbDebugMode
            // 
            cbDebugMode.AutoSize = true;
            cbDebugMode.Location = new System.Drawing.Point(14, 17);
            cbDebugMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbDebugMode.Name = "cbDebugMode";
            cbDebugMode.Size = new System.Drawing.Size(119, 24);
            cbDebugMode.TabIndex = 78;
            cbDebugMode.Text = "Debug mode";
            cbDebugMode.UseVisualStyleBackColor = true;
            // 
            // mmLog
            // 
            mmLog.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            mmLog.Location = new System.Drawing.Point(14, 52);
            mmLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            mmLog.Multiline = true;
            mmLog.Name = "mmLog";
            mmLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
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
            // llVideoTutorials
            // 
            llVideoTutorials.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            llVideoTutorials.AutoSize = true;
            llVideoTutorials.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            llVideoTutorials.Location = new System.Drawing.Point(1628, 5);
            llVideoTutorials.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            llVideoTutorials.Name = "llVideoTutorials";
            llVideoTutorials.Size = new System.Drawing.Size(140, 20);
            llVideoTutorials.TabIndex = 92;
            llVideoTutorials.TabStop = true;
            llVideoTutorials.Text = "View video tutorials";
            llVideoTutorials.LinkClicked += llVideoTutorials_LinkClicked;
            // 
            // label34
            // 
            label34.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label34.AutoSize = true;
            label34.Location = new System.Drawing.Point(1331, 5);
            label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(303, 20);
            label34.TabIndex = 97;
            label34.Text = "Much more features available in Main Demo";
            // 
            // lbTimestamp
            // 
            lbTimestamp.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbTimestamp.AutoSize = true;
            lbTimestamp.Location = new System.Drawing.Point(1421, 858);
            lbTimestamp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbTimestamp.Name = "lbTimestamp";
            lbTimestamp.Size = new System.Drawing.Size(172, 20);
            lbTimestamp.TabIndex = 105;
            lbTimestamp.Text = "Recording time: 00:00:00";
            // 
            // rbCapture
            // 
            rbCapture.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            rbCapture.AutoSize = true;
            rbCapture.Location = new System.Drawing.Point(1271, 857);
            rbCapture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rbCapture.Name = "rbCapture";
            rbCapture.Size = new System.Drawing.Size(82, 24);
            rbCapture.TabIndex = 104;
            rbCapture.Text = "Capture";
            rbCapture.UseVisualStyleBackColor = true;
            // 
            // rbPreview
            // 
            rbPreview.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            rbPreview.AutoSize = true;
            rbPreview.Checked = true;
            rbPreview.Location = new System.Drawing.Point(1182, 857);
            rbPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rbPreview.Name = "rbPreview";
            rbPreview.Size = new System.Drawing.Size(81, 24);
            rbPreview.TabIndex = 103;
            rbPreview.TabStop = true;
            rbPreview.Text = "Preview";
            rbPreview.UseVisualStyleBackColor = true;
            // 
            // btSaveScreenshot
            // 
            btSaveScreenshot.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btSaveScreenshot.Location = new System.Drawing.Point(1639, 899);
            btSaveScreenshot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btSaveScreenshot.Name = "btSaveScreenshot";
            btSaveScreenshot.Size = new System.Drawing.Size(138, 35);
            btSaveScreenshot.TabIndex = 108;
            btSaveScreenshot.Text = "Save snapshot";
            btSaveScreenshot.UseVisualStyleBackColor = true;
            btSaveScreenshot.Click += btSaveScreenshot_Click;
            // 
            // btResume
            // 
            btResume.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btResume.Location = new System.Drawing.Point(1507, 899);
            btResume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btResume.Name = "btResume";
            btResume.Size = new System.Drawing.Size(74, 35);
            btResume.TabIndex = 107;
            btResume.Text = "Resume";
            btResume.UseVisualStyleBackColor = true;
            btResume.Click += btResume_Click;
            // 
            // btPause
            // 
            btPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btPause.Location = new System.Drawing.Point(1425, 899);
            btPause.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            VideoView1.Location = new System.Drawing.Point(518, 38);
            VideoView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            VideoView1.Name = "VideoView1";
            VideoView1.Size = new System.Drawing.Size(1250, 809);
            VideoView1.StatusOverlay = null;
            VideoView1.TabIndex = 109;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1793, 948);
            Controls.Add(VideoView1);
            Controls.Add(btSaveScreenshot);
            Controls.Add(btResume);
            Controls.Add(btPause);
            Controls.Add(lbTimestamp);
            Controls.Add(rbCapture);
            Controls.Add(rbPreview);
            Controls.Add(label34);
            Controls.Add(llVideoTutorials);
            Controls.Add(btStop);
            Controls.Add(btStart);
            Controls.Add(tcMain);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Simple Video Capture Demo - Video Capture SDK .Net";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tcMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbAudioBalance).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAudioVolume).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbDarkness).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbContrast).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbLightness).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSaturation).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabControl18.ResumeLayout(false);
            tabPage71.ResumeLayout(false);
            tabPage71.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbAudAmplifyAmp).EndInit();
            tabPage72.ResumeLayout(false);
            tabPage72.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbAudEq9).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAudEq8).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAudEq7).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAudEq6).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAudEq5).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAudEq4).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAudEq3).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAudEq2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAudEq1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAudEq0).EndInit();
            tabPage76.ResumeLayout(false);
            tabPage76.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbAudTrueBass).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cbUseBestAudioInputFormat;
        private System.Windows.Forms.Button btAudioInputDeviceSettings;
        private System.Windows.Forms.ComboBox cbAudioInputLine;
        private System.Windows.Forms.ComboBox cbAudioInputFormat;
        private System.Windows.Forms.ComboBox cbAudioInputDevice;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TrackBar tbAudioBalance;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TrackBar tbAudioVolume;
        private System.Windows.Forms.CheckBox cbRecordAudio;
        private System.Windows.Forms.ComboBox cbAudioOutputDevice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbUseBestVideoInputFormat;
        private System.Windows.Forms.Button btVideoCaptureDeviceSettings;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbVideoInputFrameRate;
        private System.Windows.Forms.ComboBox cbVideoInputFormat;
        private System.Windows.Forms.ComboBox cbVideoInputDevice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl18;
        private System.Windows.Forms.TabPage tabPage71;
        private System.Windows.Forms.Label label231;
        private System.Windows.Forms.Label label230;
        private System.Windows.Forms.TrackBar tbAudAmplifyAmp;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.CheckBox cbAudAmplifyEnabled;
        private System.Windows.Forms.TabPage tabPage72;
        private System.Windows.Forms.Button btAudEqRefresh;
        private System.Windows.Forms.ComboBox cbAudEqualizerPreset;
        private System.Windows.Forms.Label label243;
        private System.Windows.Forms.Label label242;
        private System.Windows.Forms.Label label241;
        private System.Windows.Forms.Label label240;
        private System.Windows.Forms.Label label239;
        private System.Windows.Forms.Label label238;
        private System.Windows.Forms.Label label237;
        private System.Windows.Forms.Label label236;
        private System.Windows.Forms.Label label235;
        private System.Windows.Forms.Label label234;
        private System.Windows.Forms.Label label233;
        private System.Windows.Forms.Label label232;
        private System.Windows.Forms.TrackBar tbAudEq9;
        private System.Windows.Forms.TrackBar tbAudEq8;
        private System.Windows.Forms.TrackBar tbAudEq7;
        private System.Windows.Forms.TrackBar tbAudEq6;
        private System.Windows.Forms.TrackBar tbAudEq5;
        private System.Windows.Forms.TrackBar tbAudEq4;
        private System.Windows.Forms.TrackBar tbAudEq3;
        private System.Windows.Forms.TrackBar tbAudEq2;
        private System.Windows.Forms.TrackBar tbAudEq1;
        private System.Windows.Forms.TrackBar tbAudEq0;
        private System.Windows.Forms.CheckBox cbAudEqualizerEnabled;
        private System.Windows.Forms.TabPage tabPage76;
        private System.Windows.Forms.TrackBar tbAudTrueBass;
        private System.Windows.Forms.Label label254;
        private System.Windows.Forms.CheckBox cbAudTrueBassEnabled;
        internal System.Windows.Forms.LinkLabel llVideoTutorials;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.CheckBox cbDebugMode;
        private System.Windows.Forms.TextBox mmLog;
        private System.Windows.Forms.Label lbTimestamp;
        private System.Windows.Forms.RadioButton rbCapture;
        private System.Windows.Forms.RadioButton rbPreview;
        private System.Windows.Forms.Button btSaveScreenshot;
        private System.Windows.Forms.Button btResume;
        private System.Windows.Forms.Button btPause;
        private System.Windows.Forms.TextBox edOutput;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btOutputConfigure;
        private System.Windows.Forms.ComboBox cbOutputFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btSelectOutput;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbMergeTextLogos;
        private System.Windows.Forms.CheckBox cbMergeImageLogos;
        private VisioForge.Core.UI.WinForms.VideoView VideoView1;
        private System.Windows.Forms.CheckBox cbScrollingText;
    }
}

