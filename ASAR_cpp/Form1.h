#pragma once

namespace ASAR {

	using namespace System;
	using namespace System::IO;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	//TestStack.White (UI Automation)
	using namespace TestStack::White;
	using namespace TestStack::White::WindowsAPI;
	using namespace TestStack::White::UIItems;

	/// <summary>
	/// Summary for Form1
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
		DataVisualization::Charting::Series ^ seriesLocation;

		TestStack::White::Application ^ appAudacity;
		TestStack::White::UIItems::WindowItems::Window ^ audacityWindow;
		TestStack::White::UIItems::Panel ^ audacityToolDock;
		TestStack::White::UIItems::Panel ^ audacityTransportToolbar;
		TestStack::White::UIItems::Button ^ AudacityButton_Record;
		TestStack::White::UIItems::Button ^ AudacityButton_Pause;
		TestStack::White::UIItems::Button ^ AudacityButton_Play;
		TestStack::White::UIItems::Button ^ AudacityButton_Stop;
		TestStack::White::UIItems::Button ^ AudacityButton_SkipToStart;
		TestStack::White::UIItems::Button ^ AudacityButton_SkipToEnd;

	public:
		Form1(void)
		{
			InitializeComponent();
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
	private: System::Windows::Forms::Button^  btnRotateCCW;
	protected:

	private: System::Windows::Forms::Button^  btnRotateCW;
	protected:


	protected:

	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Button^  button3;
	private: System::Windows::Forms::Button^  button4;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::TextBox^  textBox1;
	private: System::IO::Ports::SerialPort^  serialPort;

	private: System::Windows::Forms::Label^  lblCurrentPosition;
	private: System::Windows::Forms::DataVisualization::Charting::Chart^  chartLocation;
	private: System::Windows::Forms::Button^  btnAudacitySkipToStart;
	private: System::Windows::Forms::Button^  btnAudacityPause;
	private: System::Windows::Forms::Button^  btnAudacityStop;
	private: System::Windows::Forms::Button^  btnAudacitySkipToEnd;
	private: System::Windows::Forms::Button^  btnAudacityPlay;
	private: System::Windows::Forms::Button^  btnAudacityRecord;
	private: System::Windows::Forms::Button^  btnAudacity;
	private: System::Windows::Forms::Label^  label3;


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
			System::Windows::Forms::DataVisualization::Charting::ChartArea^  chartArea1 = (gcnew System::Windows::Forms::DataVisualization::Charting::ChartArea());
			System::Windows::Forms::DataVisualization::Charting::Legend^  legend1 = (gcnew System::Windows::Forms::DataVisualization::Charting::Legend());
			System::Windows::Forms::DataVisualization::Charting::Series^  series1 = (gcnew System::Windows::Forms::DataVisualization::Charting::Series());
			System::Windows::Forms::DataVisualization::Charting::Title^  title1 = (gcnew System::Windows::Forms::DataVisualization::Charting::Title());
			this->btnRotateCCW = (gcnew System::Windows::Forms::Button());
			this->btnRotateCW = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->button3 = (gcnew System::Windows::Forms::Button());
			this->button4 = (gcnew System::Windows::Forms::Button());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->serialPort = (gcnew System::IO::Ports::SerialPort(this->components));
			this->lblCurrentPosition = (gcnew System::Windows::Forms::Label());
			this->chartLocation = (gcnew System::Windows::Forms::DataVisualization::Charting::Chart());
			this->btnAudacitySkipToStart = (gcnew System::Windows::Forms::Button());
			this->btnAudacityPause = (gcnew System::Windows::Forms::Button());
			this->btnAudacityStop = (gcnew System::Windows::Forms::Button());
			this->btnAudacitySkipToEnd = (gcnew System::Windows::Forms::Button());
			this->btnAudacityPlay = (gcnew System::Windows::Forms::Button());
			this->btnAudacityRecord = (gcnew System::Windows::Forms::Button());
			this->btnAudacity = (gcnew System::Windows::Forms::Button());
			this->label3 = (gcnew System::Windows::Forms::Label());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->chartLocation))->BeginInit();
			this->SuspendLayout();
			// 
			// btnRotateCCW
			// 
			this->btnRotateCCW->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 14.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnRotateCCW->Location = System::Drawing::Point(15, 12);
			this->btnRotateCCW->Name = L"btnRotateCCW";
			this->btnRotateCCW->Size = System::Drawing::Size(194, 61);
			this->btnRotateCCW->TabIndex = 0;
			this->btnRotateCCW->Text = L"Rotate Counter-Clockwise";
			this->btnRotateCCW->UseVisualStyleBackColor = true;
			this->btnRotateCCW->Click += gcnew System::EventHandler(this, &Form1::btnRotateCCW_Click);
			// 
			// btnRotateCW
			// 
			this->btnRotateCW->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 14.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnRotateCW->Location = System::Drawing::Point(215, 12);
			this->btnRotateCW->Name = L"btnRotateCW";
			this->btnRotateCW->Size = System::Drawing::Size(191, 61);
			this->btnRotateCW->TabIndex = 1;
			this->btnRotateCW->Text = L"Rotate Clockwise";
			this->btnRotateCW->UseVisualStyleBackColor = true;
			this->btnRotateCW->Click += gcnew System::EventHandler(this, &Form1::btnRotateCW_Click);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 14.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label1->Location = System::Drawing::Point(64, 76);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(148, 24);
			this->label1->TabIndex = 2;
			this->label1->Text = L"Current Position:";
			// 
			// button3
			// 
			this->button3->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->button3->Location = System::Drawing::Point(15, 148);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(103, 52);
			this->button3->TabIndex = 3;
			this->button3->Text = L"Start Recording";
			this->button3->UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this->button4->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 14.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->button4->Location = System::Drawing::Point(249, 126);
			this->button4->Name = L"button4";
			this->button4->Size = System::Drawing::Size(157, 74);
			this->button4->TabIndex = 4;
			this->button4->Text = L"Start 360 degree Recording";
			this->button4->UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(424, 19);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(60, 13);
			this->label2->TabIndex = 5;
			this->label2->Text = L"Serial Feed";
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(427, 35);
			this->textBox1->Multiline = true;
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(144, 487);
			this->textBox1->TabIndex = 6;
			// 
			// lblCurrentPosition
			// 
			this->lblCurrentPosition->AutoSize = true;
			this->lblCurrentPosition->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 20.25F, System::Drawing::FontStyle::Regular,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->lblCurrentPosition->Location = System::Drawing::Point(218, 76);
			this->lblCurrentPosition->Name = L"lblCurrentPosition";
			this->lblCurrentPosition->Size = System::Drawing::Size(40, 31);
			this->lblCurrentPosition->TabIndex = 7;
			this->lblCurrentPosition->Text = L"0°";
			// 
			// chartLocation
			// 
			this->chartLocation->BackColor = System::Drawing::Color::Transparent;
			chartArea1->Name = L"ChartArea1";
			this->chartLocation->ChartAreas->Add(chartArea1);
			legend1->Enabled = false;
			legend1->Name = L"Legend1";
			this->chartLocation->Legends->Add(legend1);
			this->chartLocation->Location = System::Drawing::Point(15, 206);
			this->chartLocation->Name = L"chartLocation";
			series1->BorderWidth = 5;
			series1->ChartArea = L"ChartArea1";
			series1->ChartType = System::Windows::Forms::DataVisualization::Charting::SeriesChartType::Polar;
			series1->Legend = L"Legend1";
			series1->MarkerBorderColor = System::Drawing::Color::Blue;
			series1->MarkerBorderWidth = 2;
			series1->MarkerSize = 15;
			series1->MarkerStep = 2;
			series1->MarkerStyle = System::Windows::Forms::DataVisualization::Charting::MarkerStyle::Circle;
			series1->Name = L"Location";
			series1->YAxisType = System::Windows::Forms::DataVisualization::Charting::AxisType::Secondary;
			this->chartLocation->Series->Add(series1);
			this->chartLocation->Size = System::Drawing::Size(391, 316);
			this->chartLocation->TabIndex = 8;
			title1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			title1->Name = L"Location";
			title1->Text = L"Location";
			this->chartLocation->Titles->Add(title1);
			// 
			// btnAudacitySkipToStart
			// 
			this->btnAudacitySkipToStart->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->btnAudacitySkipToStart->Location = System::Drawing::Point(577, 147);
			this->btnAudacitySkipToStart->Name = L"btnAudacitySkipToStart";
			this->btnAudacitySkipToStart->Size = System::Drawing::Size(100, 50);
			this->btnAudacitySkipToStart->TabIndex = 34;
			this->btnAudacitySkipToStart->Text = L"Skip to Start";
			this->btnAudacitySkipToStart->UseVisualStyleBackColor = true;
			// 
			// btnAudacityPause
			// 
			this->btnAudacityPause->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnAudacityPause->Location = System::Drawing::Point(577, 91);
			this->btnAudacityPause->Name = L"btnAudacityPause";
			this->btnAudacityPause->Size = System::Drawing::Size(100, 50);
			this->btnAudacityPause->TabIndex = 33;
			this->btnAudacityPause->Text = L"Pause";
			this->btnAudacityPause->UseVisualStyleBackColor = true;
			// 
			// btnAudacityStop
			// 
			this->btnAudacityStop->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnAudacityStop->Location = System::Drawing::Point(789, 91);
			this->btnAudacityStop->Name = L"btnAudacityStop";
			this->btnAudacityStop->Size = System::Drawing::Size(100, 50);
			this->btnAudacityStop->TabIndex = 32;
			this->btnAudacityStop->Text = L"Stop";
			this->btnAudacityStop->UseVisualStyleBackColor = true;
			// 
			// btnAudacitySkipToEnd
			// 
			this->btnAudacitySkipToEnd->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnAudacitySkipToEnd->Location = System::Drawing::Point(683, 147);
			this->btnAudacitySkipToEnd->Name = L"btnAudacitySkipToEnd";
			this->btnAudacitySkipToEnd->Size = System::Drawing::Size(100, 50);
			this->btnAudacitySkipToEnd->TabIndex = 31;
			this->btnAudacitySkipToEnd->Text = L"Skip to End";
			this->btnAudacitySkipToEnd->UseVisualStyleBackColor = true;
			// 
			// btnAudacityPlay
			// 
			this->btnAudacityPlay->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnAudacityPlay->Location = System::Drawing::Point(683, 91);
			this->btnAudacityPlay->Name = L"btnAudacityPlay";
			this->btnAudacityPlay->Size = System::Drawing::Size(100, 50);
			this->btnAudacityPlay->TabIndex = 30;
			this->btnAudacityPlay->Text = L"Play";
			this->btnAudacityPlay->UseVisualStyleBackColor = true;
			// 
			// btnAudacityRecord
			// 
			this->btnAudacityRecord->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnAudacityRecord->Location = System::Drawing::Point(789, 147);
			this->btnAudacityRecord->Name = L"btnAudacityRecord";
			this->btnAudacityRecord->Size = System::Drawing::Size(100, 50);
			this->btnAudacityRecord->TabIndex = 29;
			this->btnAudacityRecord->Text = L"Record";
			this->btnAudacityRecord->UseVisualStyleBackColor = true;
			// 
			// btnAudacity
			// 
			this->btnAudacity->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 16, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnAudacity->Location = System::Drawing::Point(577, 35);
			this->btnAudacity->Name = L"btnAudacity";
			this->btnAudacity->Size = System::Drawing::Size(312, 50);
			this->btnAudacity->TabIndex = 28;
			this->btnAudacity->Text = L"Start Audacity";
			this->btnAudacity->UseVisualStyleBackColor = true;
			this->btnAudacity->Click += gcnew System::EventHandler(this, &Form1::btnAudacity_Click);
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label3->Location = System::Drawing::Point(574, 15);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(96, 17);
			this->label3->TabIndex = 27;
			this->label3->Text = L"UI Automation";
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(994, 534);
			this->Controls->Add(this->btnAudacitySkipToStart);
			this->Controls->Add(this->btnAudacityPause);
			this->Controls->Add(this->btnAudacityStop);
			this->Controls->Add(this->btnAudacitySkipToEnd);
			this->Controls->Add(this->btnAudacityPlay);
			this->Controls->Add(this->btnAudacityRecord);
			this->Controls->Add(this->btnAudacity);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->chartLocation);
			this->Controls->Add(this->lblCurrentPosition);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->button4);
			this->Controls->Add(this->button3);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->btnRotateCW);
			this->Controls->Add(this->btnRotateCCW);
			this->Name = L"Form1";
			this->ShowIcon = false;
			this->Text = L"Automated Spatial Audio Recorder";
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->chartLocation))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion



//\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
//////////////////////////////////////////////////////////////////////////////////////////////////////////////

		/* Attn. Matthew Dabin
		* Feel free to start writing code here which will connect
		* to the COM port of choice and you can display the output
		* in a TextBox object on Form1.
		* Once you get connected and start transceiving clean signals
		* you can create functions for the buttons to send the appropriate commands.
		* After this is done you can look at writing a class for the code OR just start a class/object right away :)
		*/

	private: System::Void Form1_Load(System::Object^  sender, System::EventArgs^  e)
	{
				 // Code to run when the Form loads
				 // Initialise the graph
				 seriesLocation = ((System::Collections::Generic::IList<DataVisualization::Charting::Series^>^)chartLocation->Series)[0];
				 seriesLocation->Points->Clear();
				 seriesLocation->Points->AddXY(0, 10);
				 seriesLocation->Points->AddXY(0, 0);

				 //Initial serial port settings
				 serialPort->PortName = "COM1";
				 serialPort->BaudRate = 9600;
				 serialPort->DataBits = 8;
				 serialPort->StopBits = IO::Ports::StopBits::One;
				 serialPort->Parity = IO::Ports::Parity::None;
				 serialPort->Handshake = IO::Ports::Handshake::None;
				 serialPort->ReadBufferSize = 4096;
				 serialPort->ReadTimeout = -1;
				 serialPort->WriteBufferSize = 2048;
				 serialPort->WriteTimeout = -1;

	}

	private: System::Void btnRotateCCW_Click(System::Object^  sender, System::EventArgs^  e)
	{
				 double step = -7.5;
				 lblCurrentPosition->Text = (Convert::ToDouble(lblCurrentPosition->Text->Replace("°", "")) + step).ToString() + "°";
				 seriesLocation->Points[0]->XValue += step;
				 chartLocation->Refresh();
	}

	private: System::Void btnRotateCW_Click(System::Object^  sender, System::EventArgs^  e)
	{
				 double step = 7.5;
				 lblCurrentPosition->Text = (Convert::ToDouble(lblCurrentPosition->Text->Replace("°", "")) + step).ToString() + "°";
				 seriesLocation->Points[0]->XValue += step;
	}

private: System::Void btnAudacity_Click(System::Object^  sender, System::EventArgs^  e) {

			 if (!File::Exists(Environment::GetFolderPath(Environment::SpecialFolder::ProgramFiles) + "\\Audacity\\Audacity.exe"))
			 {
				 MessageBox::Show("Audacity is not installed...");
				 return;
			 }
			 appAudacity = TestStack::White::Application::Launch(Environment::GetFolderPath(Environment::SpecialFolder::ProgramFiles) + "\\Audacity\\Audacity.exe");

			 audacityWindow = appAudacity->GetWindow("Audacity", TestStack::White::Factory::InitializeOption::NoCache);
			 audacityToolDock = (TestStack::White::UIItems::Panel ^)audacityWindow->GetMultiple(TestStack::White::UIItems::Finders::SearchCriteria::ByText("ToolDock"))[0];
			 audacityTransportToolbar = (TestStack::White::UIItems::Panel ^)audacityToolDock->GetMultiple(TestStack::White::UIItems::Finders::SearchCriteria::ByText("Audacity Transport ToolBar"))[0];

			 AudacityButton_Record = (TestStack::White::UIItems::Button ^)audacityTransportToolbar->GetMultiple(TestStack::White::UIItems::Finders::SearchCriteria::ByText("Record"))[0];
			 AudacityButton_Pause = (TestStack::White::UIItems::Button ^)audacityTransportToolbar->GetMultiple(TestStack::White::UIItems::Finders::SearchCriteria::ByText("Pause"))[0];
			 AudacityButton_Play = (TestStack::White::UIItems::Button ^)audacityTransportToolbar->GetMultiple(TestStack::White::UIItems::Finders::SearchCriteria::ByText("Play"))[0];
			 AudacityButton_Stop = (TestStack::White::UIItems::Button ^)audacityTransportToolbar->GetMultiple(TestStack::White::UIItems::Finders::SearchCriteria::ByText("Stop"))[0];
			 AudacityButton_SkipToStart = (TestStack::White::UIItems::Button ^)audacityTransportToolbar->GetMultiple(TestStack::White::UIItems::Finders::SearchCriteria::ByText("Skip to Start"))[0];
			 AudacityButton_SkipToEnd = (TestStack::White::UIItems::Button ^)audacityTransportToolbar->GetMultiple(TestStack::White::UIItems::Finders::SearchCriteria::ByText("Skip to End"))[0];
}
};
}

