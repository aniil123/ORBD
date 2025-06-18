namespace HotelAdministration
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextAboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextReferenceBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextHotelRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.exitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.aboutProgramToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainMenuStrip.SuspendLayout();
            this.mainContextMenuStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.referenceBookToolStripMenuItem,
            this.documentToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(423, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutProgramToolStripMenuItem.Image")));
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.aboutProgramToolStripMenuItem.Text = "О программе";
            // 
            // referenceBookToolStripMenuItem
            // 
            this.referenceBookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelRoomToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.scheduleToolStripMenuItem});
            this.referenceBookToolStripMenuItem.Name = "referenceBookToolStripMenuItem";
            this.referenceBookToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.referenceBookToolStripMenuItem.Text = "Справочники";
            // 
            // hotelRoomToolStripMenuItem
            // 
            this.hotelRoomToolStripMenuItem.Name = "hotelRoomToolStripMenuItem";
            this.hotelRoomToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.hotelRoomToolStripMenuItem.Text = "Гостиничные номера";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.clientToolStripMenuItem.Text = "Клиенты";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.employeeToolStripMenuItem.Text = "Служащие";
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.scheduleToolStripMenuItem.Text = "Расписания";
            // 
            // documentToolStripMenuItem
            // 
            this.documentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.documentToolStripMenuItem.Name = "documentToolStripMenuItem";
            this.documentToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.documentToolStripMenuItem.Text = "Документы";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.reportToolStripMenuItem.Text = "Отчеты";
            // 
            // mainContextMenuStrip
            // 
            this.mainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextFileToolStripMenuItem,
            this.contextReferenceBookToolStripMenuItem,
            this.contextDocumentToolStripMenuItem});
            this.mainContextMenuStrip.Name = "mainContextMenuStrip";
            this.mainContextMenuStrip.Size = new System.Drawing.Size(150, 70);
            // 
            // contextFileToolStripMenuItem
            // 
            this.contextFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextExitToolStripMenuItem,
            this.contextAboutProgramToolStripMenuItem});
            this.contextFileToolStripMenuItem.Name = "contextFileToolStripMenuItem";
            this.contextFileToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.contextFileToolStripMenuItem.Text = "Файл";
            // 
            // contextExitToolStripMenuItem
            // 
            this.contextExitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contextExitToolStripMenuItem.Image")));
            this.contextExitToolStripMenuItem.Name = "contextExitToolStripMenuItem";
            this.contextExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.contextExitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.contextExitToolStripMenuItem.Text = "Выход";
            // 
            // contextAboutProgramToolStripMenuItem
            // 
            this.contextAboutProgramToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contextAboutProgramToolStripMenuItem.Image")));
            this.contextAboutProgramToolStripMenuItem.Name = "contextAboutProgramToolStripMenuItem";
            this.contextAboutProgramToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.contextAboutProgramToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.contextAboutProgramToolStripMenuItem.Text = "О программе";
            // 
            // contextReferenceBookToolStripMenuItem
            // 
            this.contextReferenceBookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextHotelRoomToolStripMenuItem,
            this.contextClientToolStripMenuItem,
            this.contextEmployeeToolStripMenuItem,
            this.contextScheduleToolStripMenuItem});
            this.contextReferenceBookToolStripMenuItem.Name = "contextReferenceBookToolStripMenuItem";
            this.contextReferenceBookToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.contextReferenceBookToolStripMenuItem.Text = "Справочники";
            // 
            // contextHotelRoomToolStripMenuItem
            // 
            this.contextHotelRoomToolStripMenuItem.Name = "contextHotelRoomToolStripMenuItem";
            this.contextHotelRoomToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.contextHotelRoomToolStripMenuItem.Text = "Гостиничные номера";
            // 
            // contextClientToolStripMenuItem
            // 
            this.contextClientToolStripMenuItem.Name = "contextClientToolStripMenuItem";
            this.contextClientToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.contextClientToolStripMenuItem.Text = "Клиенты";
            // 
            // contextEmployeeToolStripMenuItem
            // 
            this.contextEmployeeToolStripMenuItem.Name = "contextEmployeeToolStripMenuItem";
            this.contextEmployeeToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.contextEmployeeToolStripMenuItem.Text = "Служащие";
            // 
            // contextScheduleToolStripMenuItem
            // 
            this.contextScheduleToolStripMenuItem.Name = "contextScheduleToolStripMenuItem";
            this.contextScheduleToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.contextScheduleToolStripMenuItem.Text = "Расписания";
            // 
            // contextDocumentToolStripMenuItem
            // 
            this.contextDocumentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextReportToolStripMenuItem});
            this.contextDocumentToolStripMenuItem.Name = "contextDocumentToolStripMenuItem";
            this.contextDocumentToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.contextDocumentToolStripMenuItem.Text = "Документы";
            // 
            // contextReportToolStripMenuItem
            // 
            this.contextReportToolStripMenuItem.Name = "contextReportToolStripMenuItem";
            this.contextReportToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.contextReportToolStripMenuItem.Text = "Отчеты";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripButton,
            this.aboutProgramToolStripButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(423, 25);
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // exitToolStripButton
            // 
            this.exitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripButton.Image")));
            this.exitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitToolStripButton.Name = "exitToolStripButton";
            this.exitToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.exitToolStripButton.Text = "Выход";
            // 
            // aboutProgramToolStripButton
            // 
            this.aboutProgramToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutProgramToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutProgramToolStripButton.Image")));
            this.aboutProgramToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutProgramToolStripButton.Name = "aboutProgramToolStripButton";
            this.aboutProgramToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.aboutProgramToolStripButton.Text = "toolStripButton2";
            this.aboutProgramToolStripButton.ToolTipText = "О программе";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 254);
            this.ContextMenuStrip = this.mainContextMenuStrip;
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::HotelAdministration.Properties.Settings.Default, "FormPos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::HotelAdministration.Properties.Settings.Default.FormPos;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Администрация гостиницы";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainContextMenuStrip.ResumeLayout(false);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip mainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem contextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextReferenceBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextAboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextHotelRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextReportToolStripMenuItem;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton exitToolStripButton;
        private System.Windows.Forms.ToolStripButton aboutProgramToolStripButton;
    }
}

