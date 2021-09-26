namespace Lab05
{
    partial class FormMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settlementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSettlementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSettlementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.listViewClients = new System.Windows.Forms.ListView();
            this.columnHeaderClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageRooms = new System.Windows.Forms.TabPage();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.columnHeaderRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageSettlements = new System.Windows.Forms.TabPage();
            this.listViewSettlement = new System.Windows.Forms.ListView();
            this.columnHeaderClientFio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageClients.SuspendLayout();
            this.tabPageRooms.SuspendLayout();
            this.tabPageSettlements.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.settlementToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(969, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            this.menuStripMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripMain_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem,
            this.editClientToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.clientsToolStripMenuItem.Text = "Клиенты";
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.addClientToolStripMenuItem.Text = "Добавить";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // editClientToolStripMenuItem
            // 
            this.editClientToolStripMenuItem.Name = "editClientToolStripMenuItem";
            this.editClientToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.editClientToolStripMenuItem.Text = "Редактировать";
            this.editClientToolStripMenuItem.Click += new System.EventHandler(this.editClientToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRoomToolStripMenuItem,
            this.editRoomToolStripMenuItem});
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(79, 26);
            this.roomsToolStripMenuItem.Text = "Номера";
            // 
            // addRoomToolStripMenuItem
            // 
            this.addRoomToolStripMenuItem.Name = "addRoomToolStripMenuItem";
            this.addRoomToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.addRoomToolStripMenuItem.Text = "Добавить";
            this.addRoomToolStripMenuItem.Click += new System.EventHandler(this.addRoomToolStripMenuItem_Click);
            // 
            // editRoomToolStripMenuItem
            // 
            this.editRoomToolStripMenuItem.Name = "editRoomToolStripMenuItem";
            this.editRoomToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.editRoomToolStripMenuItem.Text = "Редактировать";
            this.editRoomToolStripMenuItem.Click += new System.EventHandler(this.editRoomToolStripMenuItem_Click);
            // 
            // settlementToolStripMenuItem
            // 
            this.settlementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSettlementToolStripMenuItem,
            this.editSettlementToolStripMenuItem});
            this.settlementToolStripMenuItem.Name = "settlementToolStripMenuItem";
            this.settlementToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.settlementToolStripMenuItem.Text = "Поселение";
            // 
            // addSettlementToolStripMenuItem
            // 
            this.addSettlementToolStripMenuItem.Name = "addSettlementToolStripMenuItem";
            this.addSettlementToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.addSettlementToolStripMenuItem.Text = "Добавить";
            this.addSettlementToolStripMenuItem.Click += new System.EventHandler(this.addSettlementToolStripMenuItem_Click);
            // 
            // editSettlementToolStripMenuItem
            // 
            this.editSettlementToolStripMenuItem.Name = "editSettlementToolStripMenuItem";
            this.editSettlementToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.editSettlementToolStripMenuItem.Text = "Редактировать";
            this.editSettlementToolStripMenuItem.Click += new System.EventHandler(this.editSettlementToolStripMenuItem_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageClients);
            this.tabControlMain.Controls.Add(this.tabPageRooms);
            this.tabControlMain.Controls.Add(this.tabPageSettlements);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 28);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(969, 455);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.listViewClients);
            this.tabPageClients.Location = new System.Drawing.Point(4, 25);
            this.tabPageClients.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageClients.Size = new System.Drawing.Size(961, 426);
            this.tabPageClients.TabIndex = 0;
            this.tabPageClients.Text = "Клиенты";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // listViewClients
            // 
            this.listViewClients.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.listViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderClient,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewClients.FullRowSelect = true;
            this.listViewClients.GridLines = true;
            this.listViewClients.HideSelection = false;
            this.listViewClients.Location = new System.Drawing.Point(4, 4);
            this.listViewClients.Margin = new System.Windows.Forms.Padding(4);
            this.listViewClients.Name = "listViewClients";
            this.listViewClients.Size = new System.Drawing.Size(953, 418);
            this.listViewClients.TabIndex = 1;
            this.listViewClients.UseCompatibleStateImageBehavior = false;
            this.listViewClients.View = System.Windows.Forms.View.Details;
            this.listViewClients.SelectedIndexChanged += new System.EventHandler(this.listViewClients_SelectedIndexChanged);
            // 
            // columnHeaderClient
            // 
            this.columnHeaderClient.Text = "Фамилия";
            this.columnHeaderClient.Width = 91;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Отчество";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Паспортные данные";
            this.columnHeader3.Width = 165;
            // 
            // tabPageRooms
            // 
            this.tabPageRooms.Controls.Add(this.listViewRooms);
            this.tabPageRooms.Location = new System.Drawing.Point(4, 25);
            this.tabPageRooms.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageRooms.Name = "tabPageRooms";
            this.tabPageRooms.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageRooms.Size = new System.Drawing.Size(961, 426);
            this.tabPageRooms.TabIndex = 1;
            this.tabPageRooms.Text = "Номера";
            this.tabPageRooms.UseVisualStyleBackColor = true;
            // 
            // listViewRooms
            // 
            this.listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderRoom});
            this.listViewRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRooms.FullRowSelect = true;
            this.listViewRooms.GridLines = true;
            this.listViewRooms.HideSelection = false;
            this.listViewRooms.Location = new System.Drawing.Point(4, 4);
            this.listViewRooms.Margin = new System.Windows.Forms.Padding(4);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(953, 418);
            this.listViewRooms.TabIndex = 2;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            this.listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderRoom
            // 
            this.columnHeaderRoom.Text = "Название номера";
            this.columnHeaderRoom.Width = 456;
            // 
            // tabPageSettlements
            // 
            this.tabPageSettlements.Controls.Add(this.listViewSettlement);
            this.tabPageSettlements.Location = new System.Drawing.Point(4, 25);
            this.tabPageSettlements.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSettlements.Name = "tabPageSettlements";
            this.tabPageSettlements.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageSettlements.Size = new System.Drawing.Size(961, 426);
            this.tabPageSettlements.TabIndex = 2;
            this.tabPageSettlements.Text = "Поселение";
            this.tabPageSettlements.UseVisualStyleBackColor = true;
            // 
            // listViewSettlement
            // 
            this.listViewSettlement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderClientFio,
            this.columnHeaderRoomNumber,
            this.columnHeaderStartDate,
            this.columnHeaderEndDate});
            this.listViewSettlement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSettlement.FullRowSelect = true;
            this.listViewSettlement.GridLines = true;
            this.listViewSettlement.HideSelection = false;
            this.listViewSettlement.Location = new System.Drawing.Point(4, 4);
            this.listViewSettlement.Margin = new System.Windows.Forms.Padding(4);
            this.listViewSettlement.Name = "listViewSettlement";
            this.listViewSettlement.Size = new System.Drawing.Size(953, 418);
            this.listViewSettlement.TabIndex = 2;
            this.listViewSettlement.UseCompatibleStateImageBehavior = false;
            this.listViewSettlement.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderClientFio
            // 
            this.columnHeaderClientFio.Text = "ФИО клиента";
            this.columnHeaderClientFio.Width = 216;
            // 
            // columnHeaderRoomNumber
            // 
            this.columnHeaderRoomNumber.Text = "Номер";
            // 
            // columnHeaderStartDate
            // 
            this.columnHeaderStartDate.Text = "Дата заселения";
            this.columnHeaderStartDate.Width = 117;
            // 
            // columnHeaderEndDate
            // 
            this.columnHeaderEndDate.Text = "Дата выезда";
            this.columnHeaderEndDate.Width = 129;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 483);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Отель";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageClients.ResumeLayout(false);
            this.tabPageRooms.ResumeLayout(false);
            this.tabPageSettlements.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settlementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSettlementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSettlementToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.TabPage tabPageRooms;
        private System.Windows.Forms.TabPage tabPageSettlements;
        private System.Windows.Forms.ListView listViewClients;
        private System.Windows.Forms.ColumnHeader columnHeaderClient;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ColumnHeader columnHeaderRoom;
        private System.Windows.Forms.ListView listViewSettlement;
        private System.Windows.Forms.ColumnHeader columnHeaderClientFio;
        private System.Windows.Forms.ColumnHeader columnHeaderRoomNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderStartDate;
        private System.Windows.Forms.ColumnHeader columnHeaderEndDate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

