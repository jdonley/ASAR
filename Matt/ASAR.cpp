// ASAR.cpp : main project file.

#using <System.dll>

#include "stdafx.h"
#include "Form1.h"

using namespace System;
using namespace System::IO::Ports;
using namespace System::Threading;
using namespace ASAR;

public ref class PortChat
{
private:
	static bool _continue;
	static SerialPort^ serialPort1;

public:
	static void Main(){
		serialPort1 = gcnew SerialPort();
		serialPort1->BaudRate = 9600;
	}

	static void Read()
	{
		while (_continue )//|| this->serialPort1->IsOpen)
		{
			try
			{
				// Recieve Text Box
				while (serialPort1->IsOpen){
					try{
						//this->textBox1->Text = this->serialPort1->ReadLine();
					}
					catch (TimeoutException^){
						//this->textBox1->Text = "Timeout Exception";
					}
					//this->button5->Enabled = false;
				}
			}
			catch (TimeoutException ^) {}
		}
	}

	//static String^ SetPortName(String^ defaultPortName){}

	//static Int32 SetPortBaudRate(Int32 defaultPortBaudRate){}

	//static Parity SetPortParity(Parity defaultPortParity){}

	//static Int32 SetPortDataBits(Int32 defaultPortDataBits){}

	//static StopBits SetPortStopBits(StopBits defaultPortStopBits){}

	//static Handshake SetPortHandshake(Handshake defaultPortHandshake){}
};

int main(array<System::String ^> ^args)
{
	// Enabling Windows XP visual effects before any controls are created
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);

	// Create the main window and run it
	Application::Run(gcnew Form1());
	
	PortChat::Main();
}