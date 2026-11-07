namespace EstructuraDeDatos.Presentation.Pilas
{
    partial class FrPilaBasica
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxData = new GroupBox();
            btnAdd = new Button();
            txtAddProduct = new TextBox();
            lbProductTitle = new Label();
            groupBoxPilaPendding = new GroupBox();
            btnClearPending = new Button();
            listViewPendding = new ListView();
            groupBoxPaid = new GroupBox();
            btnClearPaid = new Button();
            listViewPaid = new ListView();
            btnPassToPaid = new Button();
            btnPassToPedding = new Button();
            groupBoxData.SuspendLayout();
            groupBoxPilaPendding.SuspendLayout();
            groupBoxPaid.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxData
            // 
            groupBoxData.Controls.Add(btnAdd);
            groupBoxData.Controls.Add(txtAddProduct);
            groupBoxData.Controls.Add(lbProductTitle);
            groupBoxData.Location = new Point(37, 48);
            groupBoxData.Margin = new Padding(3, 4, 3, 4);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Padding = new Padding(3, 4, 3, 4);
            groupBoxData.Size = new Size(494, 101);
            groupBoxData.TabIndex = 0;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Productos de Mercado";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(336, 57);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 31);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Agregar productos";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtAddProduct
            // 
            txtAddProduct.Location = new Point(11, 57);
            txtAddProduct.Margin = new Padding(3, 4, 3, 4);
            txtAddProduct.Name = "txtAddProduct";
            txtAddProduct.Size = new Size(317, 27);
            txtAddProduct.TabIndex = 1;
            // 
            // lbProductTitle
            // 
            lbProductTitle.AutoSize = true;
            lbProductTitle.Location = new Point(11, 27);
            lbProductTitle.Name = "lbProductTitle";
            lbProductTitle.Size = new Size(138, 20);
            lbProductTitle.TabIndex = 0;
            lbProductTitle.Text = "Ingrese el producto";
            // 
            // groupBoxPilaPendding
            // 
            groupBoxPilaPendding.Controls.Add(btnClearPending);
            groupBoxPilaPendding.Controls.Add(listViewPendding);
            groupBoxPilaPendding.Location = new Point(37, 184);
            groupBoxPilaPendding.Margin = new Padding(3, 4, 3, 4);
            groupBoxPilaPendding.Name = "groupBoxPilaPendding";
            groupBoxPilaPendding.Padding = new Padding(3, 4, 3, 4);
            groupBoxPilaPendding.Size = new Size(224, 339);
            groupBoxPilaPendding.TabIndex = 1;
            groupBoxPilaPendding.TabStop = false;
            groupBoxPilaPendding.Text = "Canasta de Pendientes";
            // 
            // btnClearPending
            // 
            btnClearPending.Location = new Point(7, 300);
            btnClearPending.Margin = new Padding(3, 4, 3, 4);
            btnClearPending.Name = "btnClearPending";
            btnClearPending.Size = new Size(210, 31);
            btnClearPending.TabIndex = 3;
            btnClearPending.Text = "Vaciar Pendientes";
            btnClearPending.UseVisualStyleBackColor = true;
            btnClearPending.Click += btnClearPending_Click;
            // 
            // listViewPendding
            // 
            listViewPendding.Location = new Point(7, 29);
            listViewPendding.Margin = new Padding(3, 4, 3, 4);
            listViewPendding.Name = "listViewPendding";
            listViewPendding.Size = new Size(210, 261);
            listViewPendding.TabIndex = 0;
            listViewPendding.UseCompatibleStateImageBehavior = false;
            listViewPendding.View = View.List;
            // 
            // groupBoxPaid
            // 
            groupBoxPaid.Controls.Add(btnClearPaid);
            groupBoxPaid.Controls.Add(listViewPaid);
            groupBoxPaid.Location = new Point(306, 184);
            groupBoxPaid.Margin = new Padding(3, 4, 3, 4);
            groupBoxPaid.Name = "groupBoxPaid";
            groupBoxPaid.Padding = new Padding(3, 4, 3, 4);
            groupBoxPaid.Size = new Size(224, 339);
            groupBoxPaid.TabIndex = 2;
            groupBoxPaid.TabStop = false;
            groupBoxPaid.Text = "Canasta de Pagados";
            // 
            // btnClearPaid
            // 
            btnClearPaid.Location = new Point(7, 300);
            btnClearPaid.Margin = new Padding(3, 4, 3, 4);
            btnClearPaid.Name = "btnClearPaid";
            btnClearPaid.Size = new Size(210, 31);
            btnClearPaid.TabIndex = 4;
            btnClearPaid.Text = "Vaciar Pagados";
            btnClearPaid.UseVisualStyleBackColor = true;
            btnClearPaid.Click += btnClearPaid_Click;
            // 
            // listViewPaid
            // 
            listViewPaid.Location = new Point(7, 29);
            listViewPaid.Margin = new Padding(3, 4, 3, 4);
            listViewPaid.Name = "listViewPaid";
            listViewPaid.Size = new Size(210, 261);
            listViewPaid.TabIndex = 1;
            listViewPaid.UseCompatibleStateImageBehavior = false;
            listViewPaid.View = View.List;
            // 
            // btnPassToPaid
            // 
            btnPassToPaid.Location = new Point(267, 283);
            btnPassToPaid.Margin = new Padding(3, 4, 3, 4);
            btnPassToPaid.Name = "btnPassToPaid";
            btnPassToPaid.Size = new Size(32, 31);
            btnPassToPaid.TabIndex = 3;
            btnPassToPaid.Text = ">";
            btnPassToPaid.UseVisualStyleBackColor = true;
            btnPassToPaid.Click += btnPassToPaid_Click;
            // 
            // btnPassToPedding
            // 
            btnPassToPedding.Location = new Point(267, 321);
            btnPassToPedding.Margin = new Padding(3, 4, 3, 4);
            btnPassToPedding.Name = "btnPassToPedding";
            btnPassToPedding.Size = new Size(32, 31);
            btnPassToPedding.TabIndex = 4;
            btnPassToPedding.Text = "<";
            btnPassToPedding.UseVisualStyleBackColor = true;
            btnPassToPedding.Click += btnPassToPedding_Click;
            // 
            // FrPilaBasica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 555);
            Controls.Add(btnPassToPedding);
            Controls.Add(btnPassToPaid);
            Controls.Add(groupBoxPaid);
            Controls.Add(groupBoxPilaPendding);
            Controls.Add(groupBoxData);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(587, 602);
            MinimumSize = new Size(587, 602);
            Name = "FrPilaBasica";
            Text = "FrPilaBasica";
            groupBoxData.ResumeLayout(false);
            groupBoxData.PerformLayout();
            groupBoxPilaPendding.ResumeLayout(false);
            groupBoxPaid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxData;
        private Button btnClear;
        private Button btnAdd;
        private TextBox txtAddProduct;
        private Label lbProductTitle;
        private GroupBox groupBoxPilaPendding;
        private ListView listViewPendding;
        private GroupBox groupBoxPaid;
        private ListView listViewPaid;
        private Button btnClearPending;
        private Button btnClearPaid;
        private Button btnPassToPaid;
        private Button btnPassToPedding;
    }
}