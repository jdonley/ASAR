#pragma once

namespace ASAR {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::IO::Ports;

	/// <summary>
	/// Summary for Form1
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			findPorts();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  button1;
	protected: 
	private: System::Windows::Forms::Button^  button2;

	private: System::Windows::Forms::Button^  button3;
	private: System::Windows::Forms::Button^  button4;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::TextBox^  textBox1;
	private: System::IO::Ports::SerialPort^  serialPort1;
	private: System::Windows::Forms::ComboBox^  comboBox1;
	private: System::Windows::Forms::ComboBox^  comboBox2;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::Button^  button5;
	private: System::Windows::Forms::Button^  button6;
	private: System::Windows::Forms::TextBox^  textBox2;
	private: System::Windows::Forms::Button^  button7;
	private: System::Windows::Forms::Button^  Recieve;
	private: System::Windows::Forms::ProgressBar^  progressBar1;
	private: System::Windows::Forms::Label^  label5;
	private: System::Windows::Forms::ComboBox^  comboBox3;
	private: System::Windows::Forms::Label^  label6;
	private: System::Windows::Forms::Button^  button8;



	private: System::ComponentModel::IContainer^  components;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>


#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->components = (gcnew System::ComponentModel::Container());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->button3 = (gcnew System::Windows::Forms::Button());
			this->button4 = (gcnew System::Windows::Forms::Button());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->serialPort1 = (gcnew System::IO::Ports::SerialPort(this->components));
			this->comboBox1 = (gcnew System::Windows::Forms::ComboBox());
			this->comboBox2 = (gcnew System::Windows::Forms::ComboBox());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->button5 = (gcnew System::Windows::Forms::Button());
			this->button6 = (gcnew System::Windows::Forms::Button());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->button7 = (gcnew System::Windows::Forms::Button());
			this->Recieve = (gcnew System::Windows::Forms::Button());
			this->progressBar1 = (gcnew System::Windows::Forms::ProgressBar());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->comboBox3 = (gcnew System::Windows::Forms::ComboBox());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->button8 = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->button1->Location = System::Drawing::Point(26, 119);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(87, 30);
			this->button1->TabIndex = 0;
			this->button1->Text = L"Rotate Left";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Form1::button1_Click);
			// 
			// button2
			// 
			this->button2->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->button2->Location = System::Drawing::Point(120, 119);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(92, 30);
			this->button2->TabIndex = 1;
			this->button2->Text = L"Rotate Right";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &Form1::button2_Click);
			// 
			// button3
			// 
			this->button3->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->button3->Location = System::Drawing::Point(181, 164);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(121, 47);
			this->button3->TabIndex = 3;
			this->button3->Text = L"Start Recording";
			this->button3->UseVisualStyleBackColor = true;
			this->button3->Click += gcnew System::EventHandler(this, &Form1::button3_Click);
			// 
			// button4
			// 
			this->button4->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->button4->Location = System::Drawing::Point(25, 164);
			this->button4->Name = L"button4";
			this->button4->Size = System::Drawing::Size(124, 47);
			this->button4->TabIndex = 4;
			this->button4->Text = L"Start 360 degree Recording";
			this->button4->UseVisualStyleBackColor = true;
			this->button4->Click += gcnew System::EventHandler(this, &Form1::button4_Click);
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(22, 218);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(60, 13);
			this->label2->TabIndex = 5;
			this->label2->Text = L"Serial Feed";
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(26, 234);
			this->textBox1->Multiline = true;
			this->textBox1->Name = L"textBox1";
			this->textBox1->ReadOnly = true;
			this->textBox1->Size = System::Drawing::Size(266, 84);
			this->textBox1->TabIndex = 6;
			this->textBox1->Text = L"Recieve here";
			this->textBox1->TextChanged += gcnew System::EventHandler(this, &Form1::textBox1_TextChanged);
			// 
			// serialPort1
			// 
			this->serialPort1->ReadTimeout = 500;
			this->serialPort1->WriteTimeout = 500;
			// 
			// comboBox1
			// 
			this->comboBox1->DropDownStyle = System::Windows::Forms::ComboBoxStyle::DropDownList;
			this->comboBox1->FormattingEnabled = true;
			this->comboBox1->Location = System::Drawing::Point(181, 18);
			this->comboBox1->Name = L"comboBox1";
			this->comboBox1->Size = System::Drawing::Size(121, 21);
			this->comboBox1->TabIndex = 7;
			this->comboBox1->SelectedIndexChanged += gcnew System::EventHandler(this, &Form1::comboBox1_SelectedIndexChanged);
			// 
			// comboBox2
			// 
			this->comboBox2->AutoCompleteCustomSource->AddRange(gcnew cli::array< System::String^  >(2) { L"9600", L"115200" });
			this->comboBox2->FormattingEnabled = true;
			this->comboBox2->Items->AddRange(gcnew cli::array< System::Object^  >(2) { L"9600", L"115200" });
			this->comboBox2->Location = System::Drawing::Point(181, 52);
			this->comboBox2->Name = L"comboBox2";
			this->comboBox2->Size = System::Drawing::Size(121, 21);
			this->comboBox2->TabIndex = 8;
			this->comboBox2->SelectedIndexChanged += gcnew System::EventHandler(this, &Form1::comboBox2_SelectedIndexChanged);
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(117, 21);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(52, 13);
			this->label3->TabIndex = 9;
			this->label3->Text = L"COM port";
			this->label3->Click += gcnew System::EventHandler(this, &Form1::label3_Click);
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(117, 55);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(58, 13);
			this->label4->TabIndex = 10;
			this->label4->Text = L"Baud Rate";
			// 
			// button5
			// 
			this->button5->Location = System::Drawing::Point(25, 18);
			this->button5->Name = L"button5";
			this->button5->Size = System::Drawing::Size(80, 30);
			this->button5->TabIndex = 11;
			this->button5->Text = L"Init Serial Port";
			this->button5->UseVisualStyleBackColor = true;
			this->button5->Click += gcnew System::EventHandler(this, &Form1::button5_Click);
			// 
			// button6
			// 
			this->button6->Location = System::Drawing::Point(25, 72);
			this->button6->Name = L"button6";
			this->button6->Size = System::Drawing::Size(80, 30);
			this->button6->TabIndex = 12;
			this->button6->Text = L"Close Serial Port";
			this->button6->UseVisualStyleBackColor = true;
			this->button6->Click += gcnew System::EventHandler(this, &Form1::button6_Click);
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(25, 341);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(267, 20);
			this->textBox2->TabIndex = 13;
			this->textBox2->Text = L"Send Here";
			this->textBox2->TextChanged += gcnew System::EventHandler(this, &Form1::textBox2_TextChanged);
			// 
			// button7
			// 
			this->button7->Location = System::Drawing::Point(25, 367);
			this->button7->Name = L"button7";
			this->button7->Size = System::Drawing::Size(70, 19);
			this->button7->TabIndex = 14;
			this->button7->Text = L"Send";
			this->button7->UseVisualStyleBackColor = true;
			this->button7->Click += gcnew System::EventHandler(this, &Form1::button7_Click);
			// 
			// Recieve
			// 
			this->Recieve->Location = System::Drawing::Point(108, 367);
			this->Recieve->Name = L"Recieve";
			this->Recieve->Size = System::Drawing::Size(67, 19);
			this->Recieve->TabIndex = 15;
			this->Recieve->Text = L"Recieve";
			this->Recieve->UseVisualStyleBackColor = true;
			this->Recieve->Click += gcnew System::EventHandler(this, &Form1::button8_Click);
			// 
			// progressBar1
			// 
			this->progressBar1->Location = System::Drawing::Point(95, 401);
			this->progressBar1->Name = L"progressBar1";
			this->progressBar1->Size = System::Drawing::Size(18, 10);
			this->progressBar1->TabIndex = 16;
			this->progressBar1->Click += gcnew System::EventHandler(this, &Form1::progressBar1_Click);
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(23, 398);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(59, 13);
			this->label5->TabIndex = 17;
			this->label5->Text = L"Port Status";
			// 
			// comboBox3
			// 
			this->comboBox3->FormattingEnabled = true;
			this->comboBox3->Items->AddRange(gcnew cli::array< System::Object^  >(5) { L"1", L"2", L"3", L"4", L"5" });
			this->comboBox3->Location = System::Drawing::Point(181, 86);
			this->comboBox3->Name = L"comboBox3";
			this->comboBox3->Size = System::Drawing::Size(121, 21);
			this->comboBox3->TabIndex = 18;
			this->comboBox3->SelectedIndexChanged += gcnew System::EventHandler(this, &Form1::comboBox3_SelectedIndexChanged);
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->Location = System::Drawing::Point(117, 89);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(47, 13);
			this->label6->TabIndex = 19;
			this->label6->Text = L"Rotation";
			// 
			// button8
			// 
			this->button8->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->button8->Location = System::Drawing::Point(218, 119);
			this->button8->Name = L"button8";
			this->button8->Size = System::Drawing::Size(84, 30);
			this->button8->TabIndex = 20;
			this->button8->Text = L"Zero Set";
			this->button8->UseVisualStyleBackColor = true;
			this->button8->Click += gcnew System::EventHandler(this, &Form1::button8_Click_1);
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(319, 423);
			this->Controls->Add(this->button8);
			this->Controls->Add(this->label6);
			this->Controls->Add(this->comboBox3);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->progressBar1);
			this->Controls->Add(this->Recieve);
			this->Controls->Add(this->button7);
			this->Controls->Add(this->textBox2);
			this->Controls->Add(this->button6);
			this->Controls->Add(this->button5);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->comboBox2);
			this->Controls->Add(this->comboBox1);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->button4);
			this->Controls->Add(this->button3);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->button1);
			this->Name = L"Form1";
			this->ShowIcon = false;
			this->Text = L"Automated Spatial Audio Recorder";
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
private: System::Void Form1_Load(System::Object^  sender, System::EventArgs^  e) {}

private: System::Void comboBox1_SelectedIndexChanged(System::Object^  sender, System::EventArgs^  e) {}

private: void findPorts(void)
		 {
					  // Get availble port names
			 array<Object^>^ objectArray = SerialPort::GetPortNames();
					  // Add string to combobox
					  this->comboBox1->Items->AddRange(objectArray);
		 }

private: System::Void comboBox2_SelectedIndexChanged(System::Object^  sender, System::EventArgs^  e) {
}
private: System::Void label3_Click(System::Object^  sender, System::EventArgs^  e) {
}
private: System::Void textBox1_TextChanged(System::Object^  sender, System::EventArgs^  e) {


}
private: System::Void button8_Click(System::Object^  sender, System::EventArgs^  e) {
			 if (this->serialPort1->IsOpen){
				 this->textBox1->Text = String::Empty;
				 try{
					 this->textBox1->Text = this->serialPort1->ReadLine();
				 }
				 catch (TimeoutException^){
					 this->textBox1->Text = "Timeout Exception";
				 }
				 this->button5->Enabled = false;
				 
			 }
			 else
			 {
				 this->textBox1->Text = "Port Is Not Open";
			 }
	// Recieve Button

}
private: System::Void button5_Click(System::Object^  sender, System::EventArgs^  e) {
			 //Initialise Button
			 static int _Baud = 9600;

			 this->textBox1->Text = String::Empty;
			 //this->serialPort1->BaudRate = Int32::Parse(System::String ^_Baud);
			 //if (this->comboBox1->Text == String::Empty || this->comboBox2->Text == String::Empty) {
			 if (this->comboBox1->Text == String::Empty) {
				 // Check port setting are selected
				 this->textBox1->Text = "Select Port Settings";
			 }
			 else{
				 try{
					 if (!this->serialPort1->IsOpen){
						 this->serialPort1->PortName = this->comboBox1->Text;
						 //this->serialPort1->BaudRate = Int32::Parse(this->comboBox2->Text);
						 serialPort1->ReadTimeout = 500;
						 serialPort1->WriteTimeout = 500;
						 this->textBox1->Text = "Enter Message Here";
						 // Open Serial Port
						 this->serialPort1->Open();
						 this->progressBar1->Value = 100;
						 this->textBox1->Text = "Serial Port Initialised";
						 this->button5->Enabled = false;
						 this->comboBox2->Enabled = false;
						 this->comboBox1->Enabled = false;
					 }
					 else
					 {
						 this->textBox1->Text = "Port is not opened";
					 }
				 }
				catch (UnauthorizedAccessException^){
					this->textBox1->Text = "UnauthorisedAccess";
				}
				 
			 }
}
private: System::Void button6_Click(System::Object^  sender, System::EventArgs^  e) {
			 // Close Port
			 this->serialPort1->Close();
			 // Update Status Bar
			 this->progressBar1->Value = 0;
			 // Enable Read Button
			 // this->button8_Click->Enabled = true;
			 // Enable Init Button
			 this->button5->Enabled = true;
}
private: System::Void progressBar1_Click(System::Object^  sender, System::EventArgs^  e) {
			 // Port Status
}
private: System::Void textBox2_TextChanged(System::Object^  sender, System::EventArgs^  e) {
			 // Send Box
}
private: System::Void button7_Click(System::Object^  sender, System::EventArgs^  e) {
			 // Send Button
			 String^ name = this->serialPort1->PortName;
			 String^ textmessage = this->textBox2->Text;
			 if (this->serialPort1->IsOpen){
				 this->serialPort1->WriteLine(textmessage);
			 }
			 else{
				 this->textBox1->Text = "Port Is Not Open";
			 }
}
private: System::Void label1_Click(System::Object^  sender, System::EventArgs^  e) {
			 //Current Posistion
}
private: System::Void button4_Click(System::Object^  sender, System::EventArgs^  e) {
			 //Start 360 Recording
}
private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
			 //Rotate Left
			 String^ rotation = this->comboBox3->Text;
			 String^ textmessage = "l";
			 if (this->serialPort1->IsOpen){
				 // Update Rotation Degrees and Send command
				 this->serialPort1->WriteLine(rotation);
				 this->serialPort1->WriteLine(textmessage);
			 }
			 else{
				 this->textBox1->Text = "Port Is Not Open";
			 }
}
private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e) {
			 //Rotate Right
			 String^ rotation = this->comboBox3->Text;
			 String^ textmessage = "r";
			 if (this->serialPort1->IsOpen){
				 // Update Rotation Degrees and Send command
				 this->serialPort1->WriteLine(rotation);
				 this->serialPort1->WriteLine(textmessage);
			 }
			 else{
				 this->textBox1->Text = "Port Is Not Open";
			 }
}
private: System::Void button3_Click(System::Object^  sender, System::EventArgs^  e) {
			 //Start Recording (need Audio API)
}
private: System::Void comboBox3_SelectedIndexChanged(System::Object^  sender, System::EventArgs^  e) {
			 //Rotation combobox ( need Audio API)
}
private: System::Void button8_Click_1(System::Object^  sender, System::EventArgs^  e) {
			 //Zero Set
			 String^ textmessage = "z";
			 if (this->serialPort1->IsOpen){
				 // Return Boom to Zero Degrees
				 this->serialPort1->WriteLine(textmessage);
			 }
			 else{
				 this->textBox1->Text = "Port Is Not Open";
			 }
}
private: System::Void label1_Click_1(System::Object^  sender, System::EventArgs^  e) {
}
};
}

