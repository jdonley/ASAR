// ASAR.cpp : main project file.

#include "stdafx.h"
#include "Form1.h"

using namespace ASAR;

[STAThreadAttribute]

int main(array<System::String ^> ^args)
{
	// Enabling Windows XP visual effects before any controls are created
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false); 

	// Create the main window and run it
	Application::Run(gcnew Form1());


	/* Attn. Matthew Dabin
	 * Feel free to start writing code here which will connect
	 * to the COM port of choice and you can display the output 
	 * in a TextBox object on Form1.
	 * Once you get connected and start transceiving clean signals
	 * you can create functions for the buttons to send the appropriate commands.
	 */
	PortChat::Main();

	return 0;
}

