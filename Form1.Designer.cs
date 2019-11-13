namespace Create_your_lunch
{
    partial class Create_your_lunch
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
            this.Pizza = new System.Windows.Forms.GroupBox();
            this.Fastfood = new System.Windows.Forms.GroupBox();
            this.Sushi = new System.Windows.Forms.GroupBox();
            this.Delivery = new System.Windows.Forms.GroupBox();
            this.CheckList = new System.Windows.Forms.TextBox();
            this.Check = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Imbir = new System.Windows.Forms.CheckBox();
            this.SushiForel = new System.Windows.Forms.CheckBox();
            this.SushiLosos = new System.Windows.Forms.CheckBox();
            this.SushiYgor = new System.Windows.Forms.CheckBox();
            this.ZapechRoll = new System.Windows.Forms.CheckBox();
            this.FiladelfiaRoll = new System.Windows.Forms.CheckBox();
            this.TempuraLosos = new System.Windows.Forms.CheckBox();
            this.CaliforniaRoll = new System.Windows.Forms.CheckBox();
            this.Curier = new System.Windows.Forms.CheckBox();
            this.Curier_cycle = new System.Windows.Forms.CheckBox();
            this.Curier_car = new System.Windows.Forms.CheckBox();
            this.Curier_helicopter = new System.Windows.Forms.CheckBox();
            this.MilkCocktail = new System.Windows.Forms.CheckBox();
            this.BigMac = new System.Windows.Forms.CheckBox();
            this.Potato = new System.Windows.Forms.CheckBox();
            this.Royal = new System.Windows.Forms.CheckBox();
            this.BigTasty = new System.Windows.Forms.CheckBox();
            this.MacFlury = new System.Windows.Forms.CheckBox();
            this.CherryPie = new System.Windows.Forms.CheckBox();
            this.Soda = new System.Windows.Forms.CheckBox();
            this.FamilyPizza = new System.Windows.Forms.CheckBox();
            this.HavaiPizza = new System.Windows.Forms.CheckBox();
            this.MeatPizza = new System.Windows.Forms.CheckBox();
            this.PizzaBBQ = new System.Windows.Forms.CheckBox();
            this.CheesePizza = new System.Windows.Forms.CheckBox();
            this.Size22 = new System.Windows.Forms.RadioButton();
            this.Size = new System.Windows.Forms.GroupBox();
            this.Size30 = new System.Windows.Forms.RadioButton();
            this.Size40 = new System.Windows.Forms.RadioButton();
            this.Pizza.SuspendLayout();
            this.Fastfood.SuspendLayout();
            this.Sushi.SuspendLayout();
            this.Delivery.SuspendLayout();
            this.Size.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pizza
            // 
            this.Pizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.Pizza.Controls.Add(this.Size);
            this.Pizza.Controls.Add(this.FamilyPizza);
            this.Pizza.Controls.Add(this.HavaiPizza);
            this.Pizza.Controls.Add(this.MeatPizza);
            this.Pizza.Controls.Add(this.CheesePizza);
            this.Pizza.Controls.Add(this.PizzaBBQ);
            this.Pizza.Location = new System.Drawing.Point(12, 12);
            this.Pizza.Name = "Pizza";
            this.Pizza.Size = new System.Drawing.Size(211, 284);
            this.Pizza.TabIndex = 0;
            this.Pizza.TabStop = false;
            this.Pizza.Text = "Граф Краснов(Пиццерия)";
            // 
            // Fastfood
            // 
            this.Fastfood.BackColor = System.Drawing.Color.Lavender;
            this.Fastfood.Controls.Add(this.MilkCocktail);
            this.Fastfood.Controls.Add(this.Royal);
            this.Fastfood.Controls.Add(this.BigMac);
            this.Fastfood.Controls.Add(this.Soda);
            this.Fastfood.Controls.Add(this.Potato);
            this.Fastfood.Controls.Add(this.CherryPie);
            this.Fastfood.Controls.Add(this.MacFlury);
            this.Fastfood.Controls.Add(this.BigTasty);
            this.Fastfood.Location = new System.Drawing.Point(229, 12);
            this.Fastfood.Name = "Fastfood";
            this.Fastfood.Size = new System.Drawing.Size(189, 284);
            this.Fastfood.TabIndex = 1;
            this.Fastfood.TabStop = false;
            this.Fastfood.Text = "Mc\'Donalds(Фастфуд)";
            this.Fastfood.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // Sushi
            // 
            this.Sushi.BackColor = System.Drawing.Color.PapayaWhip;
            this.Sushi.Controls.Add(this.SushiForel);
            this.Sushi.Controls.Add(this.CaliforniaRoll);
            this.Sushi.Controls.Add(this.TempuraLosos);
            this.Sushi.Controls.Add(this.FiladelfiaRoll);
            this.Sushi.Controls.Add(this.ZapechRoll);
            this.Sushi.Controls.Add(this.SushiYgor);
            this.Sushi.Controls.Add(this.SushiLosos);
            this.Sushi.Controls.Add(this.Imbir);
            this.Sushi.Location = new System.Drawing.Point(424, 12);
            this.Sushi.Name = "Sushi";
            this.Sushi.Size = new System.Drawing.Size(189, 284);
            this.Sushi.TabIndex = 1;
            this.Sushi.TabStop = false;
            this.Sushi.Text = "Важная рыба(Суши и роллы)";
            // 
            // Delivery
            // 
            this.Delivery.BackColor = System.Drawing.Color.MistyRose;
            this.Delivery.Controls.Add(this.Curier_car);
            this.Delivery.Controls.Add(this.Curier);
            this.Delivery.Controls.Add(this.Curier_cycle);
            this.Delivery.Controls.Add(this.Curier_helicopter);
            this.Delivery.Location = new System.Drawing.Point(619, 12);
            this.Delivery.Name = "Delivery";
            this.Delivery.Size = new System.Drawing.Size(193, 105);
            this.Delivery.TabIndex = 3;
            this.Delivery.TabStop = false;
            this.Delivery.Text = "Способ доставки";
            // 
            // CheckList
            // 
            this.CheckList.Location = new System.Drawing.Point(619, 123);
            this.CheckList.Multiline = true;
            this.CheckList.Name = "CheckList";
            this.CheckList.ReadOnly = true;
            this.CheckList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CheckList.Size = new System.Drawing.Size(190, 173);
            this.CheckList.TabIndex = 4;
            this.CheckList.UseWaitCursor = true;
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(12, 302);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(281, 31);
            this.Check.TabIndex = 5;
            this.Check.Text = "Расчёт";
            this.Check.UseVisualStyleBackColor = true;
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(299, 302);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(292, 31);
            this.Clean.TabIndex = 6;
            this.Clean.Text = "Очистить";
            this.Clean.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(597, 302);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(215, 31);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Imbir
            // 
            this.Imbir.AutoSize = true;
            this.Imbir.Location = new System.Drawing.Point(6, 261);
            this.Imbir.Name = "Imbir";
            this.Imbir.Size = new System.Drawing.Size(110, 17);
            this.Imbir.TabIndex = 25;
            this.Imbir.Text = "Имбирь (20 руб.)";
            this.Imbir.UseVisualStyleBackColor = true;
            // 
            // SushiForel
            // 
            this.SushiForel.AutoSize = true;
            this.SushiForel.Location = new System.Drawing.Point(6, 229);
            this.SushiForel.Name = "SushiForel";
            this.SushiForel.Size = new System.Drawing.Size(160, 17);
            this.SushiForel.TabIndex = 24;
            this.SushiForel.Text = "Суши с форелью (100 руб.)";
            this.SushiForel.UseVisualStyleBackColor = true;
            // 
            // SushiLosos
            // 
            this.SushiLosos.AutoSize = true;
            this.SushiLosos.Location = new System.Drawing.Point(6, 194);
            this.SushiLosos.Name = "SushiLosos";
            this.SushiLosos.Size = new System.Drawing.Size(152, 17);
            this.SushiLosos.TabIndex = 23;
            this.SushiLosos.Text = "Суши с лососем (80 руб.)";
            this.SushiLosos.UseVisualStyleBackColor = true;
            // 
            // SushiYgor
            // 
            this.SushiYgor.AutoSize = true;
            this.SushiYgor.Location = new System.Drawing.Point(6, 157);
            this.SushiYgor.Name = "SushiYgor";
            this.SushiYgor.Size = new System.Drawing.Size(138, 17);
            this.SushiYgor.TabIndex = 22;
            this.SushiYgor.Text = "Суши с угрём (80 руб.)";
            this.SushiYgor.UseVisualStyleBackColor = true;
            // 
            // ZapechRoll
            // 
            this.ZapechRoll.AutoSize = true;
            this.ZapechRoll.Location = new System.Drawing.Point(6, 123);
            this.ZapechRoll.Name = "ZapechRoll";
            this.ZapechRoll.Size = new System.Drawing.Size(165, 17);
            this.ZapechRoll.TabIndex = 21;
            this.ZapechRoll.Text = "Запеченный ролл (300 руб.)";
            this.ZapechRoll.UseVisualStyleBackColor = true;
            // 
            // FiladelfiaRoll
            // 
            this.FiladelfiaRoll.AutoSize = true;
            this.FiladelfiaRoll.Location = new System.Drawing.Point(6, 88);
            this.FiladelfiaRoll.Name = "FiladelfiaRoll";
            this.FiladelfiaRoll.Size = new System.Drawing.Size(176, 17);
            this.FiladelfiaRoll.TabIndex = 20;
            this.FiladelfiaRoll.Text = "Филадельфия ролл (300 руб.)";
            this.FiladelfiaRoll.UseVisualStyleBackColor = true;
            this.FiladelfiaRoll.CheckedChanged += new System.EventHandler(this.checkBox37_CheckedChanged);
            // 
            // TempuraLosos
            // 
            this.TempuraLosos.AutoSize = true;
            this.TempuraLosos.Location = new System.Drawing.Point(6, 52);
            this.TempuraLosos.Name = "TempuraLosos";
            this.TempuraLosos.Size = new System.Drawing.Size(159, 17);
            this.TempuraLosos.TabIndex = 19;
            this.TempuraLosos.Text = "Темпура лосось (300 руб.)";
            this.TempuraLosos.UseVisualStyleBackColor = true;
            // 
            // CaliforniaRoll
            // 
            this.CaliforniaRoll.AutoSize = true;
            this.CaliforniaRoll.Location = new System.Drawing.Point(6, 19);
            this.CaliforniaRoll.Name = "CaliforniaRoll";
            this.CaliforniaRoll.Size = new System.Drawing.Size(166, 17);
            this.CaliforniaRoll.TabIndex = 18;
            this.CaliforniaRoll.Text = "Калифорния ролл (250 руб.)";
            this.CaliforniaRoll.UseVisualStyleBackColor = true;
            // 
            // Curier
            // 
            this.Curier.AutoSize = true;
            this.Curier.Location = new System.Drawing.Point(6, 19);
            this.Curier.Name = "Curier";
            this.Curier.Size = new System.Drawing.Size(158, 17);
            this.Curier.TabIndex = 36;
            this.Curier.Text = "Пеший курьер(Бесплатно)";
            this.Curier.UseVisualStyleBackColor = true;
            // 
            // Curier_cycle
            // 
            this.Curier_cycle.AutoSize = true;
            this.Curier_cycle.Location = new System.Drawing.Point(6, 42);
            this.Curier_cycle.Name = "Curier_cycle";
            this.Curier_cycle.Size = new System.Drawing.Size(190, 17);
            this.Curier_cycle.TabIndex = 37;
            this.Curier_cycle.Text = "Курьер на велосипеде (100 руб.)";
            this.Curier_cycle.UseVisualStyleBackColor = true;
            // 
            // Curier_car
            // 
            this.Curier_car.AutoSize = true;
            this.Curier_car.Location = new System.Drawing.Point(6, 65);
            this.Curier_car.Name = "Curier_car";
            this.Curier_car.Size = new System.Drawing.Size(170, 17);
            this.Curier_car.TabIndex = 38;
            this.Curier_car.Text = "Курьер на машине (250 руб.)";
            this.Curier_car.UseVisualStyleBackColor = true;
            // 
            // Curier_helicopter
            // 
            this.Curier_helicopter.AutoSize = true;
            this.Curier_helicopter.Location = new System.Drawing.Point(6, 88);
            this.Curier_helicopter.Name = "Curier_helicopter";
            this.Curier_helicopter.Size = new System.Drawing.Size(188, 17);
            this.Curier_helicopter.TabIndex = 39;
            this.Curier_helicopter.Text = "Курьер на вертолете (5000 руб.)";
            this.Curier_helicopter.UseVisualStyleBackColor = true;
            // 
            // MilkCocktail
            // 
            this.MilkCocktail.AutoSize = true;
            this.MilkCocktail.Location = new System.Drawing.Point(6, 229);
            this.MilkCocktail.Name = "MilkCocktail";
            this.MilkCocktail.Size = new System.Drawing.Size(178, 17);
            this.MilkCocktail.TabIndex = 32;
            this.MilkCocktail.Text = "Молочный коктейль (100 руб.)";
            this.MilkCocktail.UseVisualStyleBackColor = true;
            // 
            // BigMac
            // 
            this.BigMac.AutoSize = true;
            this.BigMac.Location = new System.Drawing.Point(6, 19);
            this.BigMac.Name = "BigMac";
            this.BigMac.Size = new System.Drawing.Size(117, 17);
            this.BigMac.TabIndex = 26;
            this.BigMac.Text = "Биг мак (140 руб.)";
            this.BigMac.UseVisualStyleBackColor = true;
            // 
            // Potato
            // 
            this.Potato.AutoSize = true;
            this.Potato.Location = new System.Drawing.Point(6, 52);
            this.Potato.Name = "Potato";
            this.Potato.Size = new System.Drawing.Size(155, 17);
            this.Potato.TabIndex = 27;
            this.Potato.Text = "Картофель фри (100 руб.)";
            this.Potato.UseVisualStyleBackColor = true;
            // 
            // Royal
            // 
            this.Royal.AutoSize = true;
            this.Royal.Location = new System.Drawing.Point(6, 88);
            this.Royal.Name = "Royal";
            this.Royal.Size = new System.Drawing.Size(138, 17);
            this.Royal.TabIndex = 28;
            this.Royal.Text = "Роял бургер (200 руб.)";
            this.Royal.UseVisualStyleBackColor = true;
            // 
            // BigTasty
            // 
            this.BigTasty.AutoSize = true;
            this.BigTasty.Location = new System.Drawing.Point(6, 123);
            this.BigTasty.Name = "BigTasty";
            this.BigTasty.Size = new System.Drawing.Size(131, 17);
            this.BigTasty.TabIndex = 29;
            this.BigTasty.Text = "Биг тэйсти (250 руб.)";
            this.BigTasty.UseVisualStyleBackColor = true;
            // 
            // MacFlury
            // 
            this.MacFlury.AutoSize = true;
            this.MacFlury.Location = new System.Drawing.Point(6, 157);
            this.MacFlury.Name = "MacFlury";
            this.MacFlury.Size = new System.Drawing.Size(131, 17);
            this.MacFlury.TabIndex = 30;
            this.MacFlury.Text = "Мак флури (120 руб.)";
            this.MacFlury.UseVisualStyleBackColor = true;
            // 
            // CherryPie
            // 
            this.CherryPie.AutoSize = true;
            this.CherryPie.Location = new System.Drawing.Point(6, 194);
            this.CherryPie.Name = "CherryPie";
            this.CherryPie.Size = new System.Drawing.Size(166, 17);
            this.CherryPie.TabIndex = 31;
            this.CherryPie.Text = "Пирожок с вишней (60 руб.)";
            this.CherryPie.UseVisualStyleBackColor = true;
            // 
            // Soda
            // 
            this.Soda.AutoSize = true;
            this.Soda.Location = new System.Drawing.Point(6, 261);
            this.Soda.Name = "Soda";
            this.Soda.Size = new System.Drawing.Size(124, 17);
            this.Soda.TabIndex = 33;
            this.Soda.Text = "Газировка (80 руб.)";
            this.Soda.UseVisualStyleBackColor = true;
            // 
            // FamilyPizza
            // 
            this.FamilyPizza.AutoSize = true;
            this.FamilyPizza.Location = new System.Drawing.Point(6, 123);
            this.FamilyPizza.Name = "FamilyPizza";
            this.FamilyPizza.Size = new System.Drawing.Size(160, 17);
            this.FamilyPizza.TabIndex = 34;
            this.FamilyPizza.Text = "Семейная пицца (300 руб.)";
            this.FamilyPizza.UseVisualStyleBackColor = true;
            // 
            // HavaiPizza
            // 
            this.HavaiPizza.AutoSize = true;
            this.HavaiPizza.Location = new System.Drawing.Point(6, 156);
            this.HavaiPizza.Name = "HavaiPizza";
            this.HavaiPizza.Size = new System.Drawing.Size(163, 17);
            this.HavaiPizza.TabIndex = 35;
            this.HavaiPizza.Text = "Гавайская пицца (330 руб.)";
            this.HavaiPizza.UseVisualStyleBackColor = true;
            // 
            // MeatPizza
            // 
            this.MeatPizza.AutoSize = true;
            this.MeatPizza.Location = new System.Drawing.Point(6, 192);
            this.MeatPizza.Name = "MeatPizza";
            this.MeatPizza.Size = new System.Drawing.Size(148, 17);
            this.MeatPizza.TabIndex = 36;
            this.MeatPizza.Text = "Мясная пицца (350 руб.)";
            this.MeatPizza.UseVisualStyleBackColor = true;
            // 
            // PizzaBBQ
            // 
            this.PizzaBBQ.AutoSize = true;
            this.PizzaBBQ.Location = new System.Drawing.Point(6, 227);
            this.PizzaBBQ.Name = "PizzaBBQ";
            this.PizzaBBQ.Size = new System.Drawing.Size(133, 17);
            this.PizzaBBQ.TabIndex = 37;
            this.PizzaBBQ.Text = "Пицца BBQ (400 руб.)";
            this.PizzaBBQ.UseVisualStyleBackColor = true;
            // 
            // CheesePizza
            // 
            this.CheesePizza.AutoSize = true;
            this.CheesePizza.Location = new System.Drawing.Point(6, 261);
            this.CheesePizza.Name = "CheesePizza";
            this.CheesePizza.Size = new System.Drawing.Size(148, 17);
            this.CheesePizza.TabIndex = 38;
            this.CheesePizza.Text = "Cырная пицца (280 руб.)";
            this.CheesePizza.UseVisualStyleBackColor = true;
            // 
            // Size22
            // 
            this.Size22.AutoSize = true;
            this.Size22.Location = new System.Drawing.Point(6, 19);
            this.Size22.Name = "Size22";
            this.Size22.Size = new System.Drawing.Size(54, 17);
            this.Size22.TabIndex = 8;
            this.Size22.TabStop = true;
            this.Size22.Text = "22 см";
            this.Size22.UseVisualStyleBackColor = true;
            // 
            // Size
            // 
            this.Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(157)))));
            this.Size.Controls.Add(this.Size40);
            this.Size.Controls.Add(this.Size30);
            this.Size.Controls.Add(this.Size22);
            this.Size.Location = new System.Drawing.Point(6, 26);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(199, 91);
            this.Size.TabIndex = 39;
            this.Size.TabStop = false;
            this.Size.Text = "Размер пиццы";
            // 
            // Size30
            // 
            this.Size30.AutoSize = true;
            this.Size30.Location = new System.Drawing.Point(6, 42);
            this.Size30.Name = "Size30";
            this.Size30.Size = new System.Drawing.Size(110, 17);
            this.Size30.TabIndex = 9;
            this.Size30.TabStop = true;
            this.Size30.Text = "30 см (+100 руб.)";
            this.Size30.UseVisualStyleBackColor = true;
            // 
            // Size40
            // 
            this.Size40.AutoSize = true;
            this.Size40.Location = new System.Drawing.Point(6, 68);
            this.Size40.Name = "Size40";
            this.Size40.Size = new System.Drawing.Size(110, 17);
            this.Size40.TabIndex = 10;
            this.Size40.TabStop = true;
            this.Size40.Text = "40 см (+250 руб.)";
            this.Size40.UseVisualStyleBackColor = true;
            // 
            // Create_your_lunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(823, 343);
            this.Controls.Add(this.Fastfood);
            this.Controls.Add(this.Pizza);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Sushi);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.CheckList);
            this.Controls.Add(this.Delivery);
            this.Name = "Create_your_lunch";
            this.Text = "Доставка обеда";
            this.Pizza.ResumeLayout(false);
            this.Pizza.PerformLayout();
            this.Fastfood.ResumeLayout(false);
            this.Fastfood.PerformLayout();
            this.Sushi.ResumeLayout(false);
            this.Sushi.PerformLayout();
            this.Delivery.ResumeLayout(false);
            this.Delivery.PerformLayout();
            this.Size.ResumeLayout(false);
            this.Size.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Pizza;
        private System.Windows.Forms.GroupBox Fastfood;
        private System.Windows.Forms.GroupBox Sushi;
        private System.Windows.Forms.GroupBox Delivery;
        private System.Windows.Forms.TextBox CheckList;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.CheckBox SushiForel;
        private System.Windows.Forms.CheckBox CaliforniaRoll;
        private System.Windows.Forms.CheckBox TempuraLosos;
        private System.Windows.Forms.CheckBox FiladelfiaRoll;
        private System.Windows.Forms.CheckBox ZapechRoll;
        private System.Windows.Forms.CheckBox SushiYgor;
        private System.Windows.Forms.CheckBox SushiLosos;
        private System.Windows.Forms.CheckBox Imbir;
        private System.Windows.Forms.CheckBox Curier_car;
        private System.Windows.Forms.CheckBox Curier;
        private System.Windows.Forms.CheckBox Curier_cycle;
        private System.Windows.Forms.CheckBox Curier_helicopter;
        private System.Windows.Forms.CheckBox FamilyPizza;
        private System.Windows.Forms.CheckBox HavaiPizza;
        private System.Windows.Forms.CheckBox MeatPizza;
        private System.Windows.Forms.CheckBox CheesePizza;
        private System.Windows.Forms.CheckBox PizzaBBQ;
        private System.Windows.Forms.CheckBox MilkCocktail;
        private System.Windows.Forms.CheckBox Royal;
        private System.Windows.Forms.CheckBox BigMac;
        private System.Windows.Forms.CheckBox Soda;
        private System.Windows.Forms.CheckBox Potato;
        private System.Windows.Forms.CheckBox CherryPie;
        private System.Windows.Forms.CheckBox MacFlury;
        private System.Windows.Forms.CheckBox BigTasty;
        private System.Windows.Forms.GroupBox Size;
        private System.Windows.Forms.RadioButton Size40;
        private System.Windows.Forms.RadioButton Size30;
        private System.Windows.Forms.RadioButton Size22;
    }
}

