namespace Pro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label адресLabel;
            this.database1DataSet1 = new Pro.Database1DataSet();
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter1 = new Pro.Database1DataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager1 = new Pro.Database1DataSetTableAdapters.TableAdapterManager();
            this.tableBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.tableBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.фамилияTextBox1 = new System.Windows.Forms.TextBox();
            this.имяTextBox1 = new System.Windows.Forms.TextBox();
            this.отчествоTextBox1 = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.адресTextBox1 = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1BindingNavigator)).BeginInit();
            this.tableBindingSource1BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.database1DataSet1;
            // 
            // tableTableAdapter1
            // 
            this.tableTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.TableTableAdapter = this.tableTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Pro.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableBindingSource1BindingNavigator
            // 
            this.tableBindingSource1BindingNavigator.AddNewItem = this.toolStripButton6;
            this.tableBindingSource1BindingNavigator.BindingSource = this.tableBindingSource1;
            this.tableBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.tableBindingSource1BindingNavigator.DeleteItem = this.toolStripButton7;
            this.tableBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator3,
            this.toolStripButton6,
            this.toolStripButton7,
            this.tableBindingSource1BindingNavigatorSaveItem});
            this.tableBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton2;
            this.tableBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton5;
            this.tableBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton4;
            this.tableBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton3;
            this.tableBindingSource1BindingNavigator.Name = "tableBindingSource1BindingNavigator";
            this.tableBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.tableBindingSource1BindingNavigator.Size = new System.Drawing.Size(620, 25);
            this.tableBindingSource1BindingNavigator.TabIndex = 0;
            this.tableBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "bindingNavigatorMoveFirstItem";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Переместить в начало";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "bindingNavigatorMovePreviousItem";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "bindingNavigatorPositionItem";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "bindingNavigatorCountItem";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 15);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "bindingNavigatorMoveNextItem";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton4.Text = "Переместить вперед";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "bindingNavigatorMoveLastItem";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton5.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "bindingNavigatorAddNewItem";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Добавить";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "bindingNavigatorDeleteItem";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton7.Text = "Удалить";
            // 
            // tableBindingSource1BindingNavigatorSaveItem
            // 
            this.tableBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingSource1BindingNavigatorSaveItem.Image")));
            this.tableBindingSource1BindingNavigatorSaveItem.Name = "tableBindingSource1BindingNavigatorSaveItem";
            this.tableBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tableBindingSource1BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tableBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.TableBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(301, 110);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(20, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource1, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(400, 107);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(200, 22);
            this.idTextBox1.TabIndex = 2;
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(301, 138);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(59, 13);
            фамилияLabel.TabIndex = 3;
            фамилияLabel.Text = "Фамилия:";
            // 
            // фамилияTextBox1
            // 
            this.фамилияTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource1, "Фамилия", true));
            this.фамилияTextBox1.Location = new System.Drawing.Point(400, 135);
            this.фамилияTextBox1.Name = "фамилияTextBox1";
            this.фамилияTextBox1.Size = new System.Drawing.Size(200, 22);
            this.фамилияTextBox1.TabIndex = 4;
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(301, 166);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(32, 13);
            имяLabel.TabIndex = 5;
            имяLabel.Text = "Имя:";
            // 
            // имяTextBox1
            // 
            this.имяTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource1, "Имя", true));
            this.имяTextBox1.Location = new System.Drawing.Point(400, 163);
            this.имяTextBox1.Name = "имяTextBox1";
            this.имяTextBox1.Size = new System.Drawing.Size(200, 22);
            this.имяTextBox1.TabIndex = 6;
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(301, 194);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(58, 13);
            отчествоLabel.TabIndex = 7;
            отчествоLabel.Text = "Отчество:";
            // 
            // отчествоTextBox1
            // 
            this.отчествоTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource1, "Отчество", true));
            this.отчествоTextBox1.Location = new System.Drawing.Point(400, 191);
            this.отчествоTextBox1.Name = "отчествоTextBox1";
            this.отчествоTextBox1.Size = new System.Drawing.Size(200, 22);
            this.отчествоTextBox1.TabIndex = 8;
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(301, 223);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(93, 13);
            дата_рожденияLabel.TabIndex = 9;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // дата_рожденияDateTimePicker1
            // 
            this.дата_рожденияDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tableBindingSource1, "Дата рождения", true));
            this.дата_рожденияDateTimePicker1.Location = new System.Drawing.Point(400, 219);
            this.дата_рожденияDateTimePicker1.Name = "дата_рожденияDateTimePicker1";
            this.дата_рожденияDateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.дата_рожденияDateTimePicker1.TabIndex = 10;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(301, 250);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 11;
            адресLabel.Text = "Адрес:";
            // 
            // адресTextBox1
            // 
            this.адресTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource1, "Адрес", true));
            this.адресTextBox1.Location = new System.Drawing.Point(400, 247);
            this.адресTextBox1.Name = "адресTextBox1";
            this.адресTextBox1.Size = new System.Drawing.Size(200, 22);
            this.адресTextBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(620, 337);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox1);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox1);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox1);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker1);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox1);
            this.Controls.Add(this.tableBindingSource1BindingNavigator);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1BindingNavigator)).EndInit();
            this.tableBindingSource1BindingNavigator.ResumeLayout(false);
            this.tableBindingSource1BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database1DataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private Database1DataSetTableAdapters.TableTableAdapter tableTableAdapter1;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator tableBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tableBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox фамилияTextBox1;
        private System.Windows.Forms.TextBox имяTextBox1;
        private System.Windows.Forms.TextBox отчествоTextBox1;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker1;
        private System.Windows.Forms.TextBox адресTextBox1;
    }
}

