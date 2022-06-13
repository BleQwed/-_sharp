namespace _1_view
{
    partial class CreatePlane
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
            this.Title2 = new System.Windows.Forms.Label();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.LengthLable = new System.Windows.Forms.Label();
            this.DiameterLabel = new System.Windows.Forms.Label();
            this.PowerLable = new System.Windows.Forms.Label();
            this.LengthOfWing = new System.Windows.Forms.TextBox();
            this.WheelDiameter = new System.Windows.Forms.TextBox();
            this.Brand = new System.Windows.Forms.TextBox();
            this.PowerOfEngine = new System.Windows.Forms.TextBox();
            this.PlaneCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title2
            // 
            this.Title2.AutoSize = true;
            this.Title2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title2.Location = new System.Drawing.Point(96, 9);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(200, 23);
            this.Title2.TabIndex = 1;
            this.Title2.Text = "Введите данные:";
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrandLabel.Location = new System.Drawing.Point(13, 52);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(160, 18);
            this.BrandLabel.TabIndex = 2;
            this.BrandLabel.Text = "Бренд самолёта:";
            // 
            // LengthLable
            // 
            this.LengthLable.AutoSize = true;
            this.LengthLable.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthLable.Location = new System.Drawing.Point(13, 88);
            this.LengthLable.Name = "LengthLable";
            this.LengthLable.Size = new System.Drawing.Size(132, 18);
            this.LengthLable.TabIndex = 3;
            this.LengthLable.Text = "Длина крыла:";
            // 
            // DiameterLabel
            // 
            this.DiameterLabel.AutoSize = true;
            this.DiameterLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiameterLabel.Location = new System.Drawing.Point(13, 128);
            this.DiameterLabel.Name = "DiameterLabel";
            this.DiameterLabel.Size = new System.Drawing.Size(210, 18);
            this.DiameterLabel.TabIndex = 4;
            this.DiameterLabel.Text = "Диаметр колёс шасси:\r\n";
            // 
            // PowerLable
            // 
            this.PowerLable.AutoSize = true;
            this.PowerLable.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PowerLable.Location = new System.Drawing.Point(13, 167);
            this.PowerLable.Name = "PowerLable";
            this.PowerLable.Size = new System.Drawing.Size(204, 18);
            this.PowerLable.TabIndex = 5;
            this.PowerLable.Text = "Мощность двигателя:";
            // 
            // LengthOfWing
            // 
            this.LengthOfWing.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthOfWing.Location = new System.Drawing.Point(229, 88);
            this.LengthOfWing.Multiline = true;
            this.LengthOfWing.Name = "LengthOfWing";
            this.LengthOfWing.Size = new System.Drawing.Size(124, 30);
            this.LengthOfWing.TabIndex = 6;
            this.LengthOfWing.Text = "11";
            // 
            // WheelDiameter
            // 
            this.WheelDiameter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WheelDiameter.Location = new System.Drawing.Point(229, 128);
            this.WheelDiameter.Multiline = true;
            this.WheelDiameter.Name = "WheelDiameter";
            this.WheelDiameter.Size = new System.Drawing.Size(124, 30);
            this.WheelDiameter.TabIndex = 7;
            this.WheelDiameter.Text = "31,8";
            // 
            // Brand
            // 
            this.Brand.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Brand.Location = new System.Drawing.Point(229, 52);
            this.Brand.Multiline = true;
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(124, 30);
            this.Brand.TabIndex = 8;
            this.Brand.Text = "Boeing";
            // 
            // PowerOfEngine
            // 
            this.PowerOfEngine.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PowerOfEngine.Location = new System.Drawing.Point(229, 167);
            this.PowerOfEngine.Multiline = true;
            this.PowerOfEngine.Name = "PowerOfEngine";
            this.PowerOfEngine.Size = new System.Drawing.Size(124, 30);
            this.PowerOfEngine.TabIndex = 9;
            this.PowerOfEngine.Text = "192,2";
            // 
            // PlaneCreate
            // 
            this.PlaneCreate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaneCreate.Location = new System.Drawing.Point(16, 212);
            this.PlaneCreate.Name = "PlaneCreate";
            this.PlaneCreate.Size = new System.Drawing.Size(337, 65);
            this.PlaneCreate.TabIndex = 10;
            this.PlaneCreate.Text = "Создать самолёт";
            this.PlaneCreate.UseVisualStyleBackColor = true;
            this.PlaneCreate.Click += new System.EventHandler(this.PlaneCreate_Click);
            // 
            // CreatePlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 289);
            this.Controls.Add(this.PlaneCreate);
            this.Controls.Add(this.PowerOfEngine);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.WheelDiameter);
            this.Controls.Add(this.LengthOfWing);
            this.Controls.Add(this.PowerLable);
            this.Controls.Add(this.DiameterLabel);
            this.Controls.Add(this.LengthLable);
            this.Controls.Add(this.BrandLabel);
            this.Controls.Add(this.Title2);
            this.Name = "CreatePlane";
            this.Text = "Создание самолёта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title2;
        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.Label LengthLable;
        private System.Windows.Forms.Label DiameterLabel;
        private System.Windows.Forms.Label PowerLable;
        private System.Windows.Forms.TextBox LengthOfWing;
        private System.Windows.Forms.TextBox WheelDiameter;
        private System.Windows.Forms.TextBox Brand;
        private System.Windows.Forms.TextBox PowerOfEngine;
        private System.Windows.Forms.Button PlaneCreate;
    }
}

