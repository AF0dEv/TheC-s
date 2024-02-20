#pragma once
#include <sstream>

namespace ProjCLR {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	



	/// <summary>
	/// Summary for Form1
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
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
	private: System::Windows::Forms::Button^ button1;
	private: System::Windows::Forms::TextBox^ txtN;

	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::TextBox^ txtOctalToDecimal;
	private: System::Windows::Forms::TextBox^ txtHexadecimalToDecimal;


	private: System::Windows::Forms::TextBox^ txtBinaryToDecimal;


	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::Label^ label4;
	private: System::Windows::Forms::TextBox^ txtDecToBinary;
	private: System::Windows::Forms::Label^ label5;
	private: System::Windows::Forms::TextBox^ caixaN;


	private: System::Windows::Forms::Label^ label6;
	private: System::Windows::Forms::Label^ label7;
	private: System::Windows::Forms::Label^ label8;
	private: System::Windows::Forms::Button^ button2;
	private: System::Windows::Forms::TextBox^ caixaenderecoN;
	private: System::Windows::Forms::Label^ label9;
	private: System::Windows::Forms::TextBox^ caixaDecimal;
	private: System::Windows::Forms::Label^ label10;
	private: System::Windows::Forms::TextBox^ caixaDecimalToHexadecima;
	private: System::Windows::Forms::Label^ label11;
	private: System::Windows::Forms::TextBox^ caixaPointer2;
	private: System::Windows::Forms::Label^ label12;
	private: System::Windows::Forms::TextBox^ caixaFinal;
	private: System::Windows::Forms::Label^ label13;


	protected:

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->txtN = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->txtOctalToDecimal = (gcnew System::Windows::Forms::TextBox());
			this->txtHexadecimalToDecimal = (gcnew System::Windows::Forms::TextBox());
			this->txtBinaryToDecimal = (gcnew System::Windows::Forms::TextBox());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->txtDecToBinary = (gcnew System::Windows::Forms::TextBox());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->caixaN = (gcnew System::Windows::Forms::TextBox());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->label7 = (gcnew System::Windows::Forms::Label());
			this->label8 = (gcnew System::Windows::Forms::Label());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->caixaenderecoN = (gcnew System::Windows::Forms::TextBox());
			this->label9 = (gcnew System::Windows::Forms::Label());
			this->caixaDecimal = (gcnew System::Windows::Forms::TextBox());
			this->label10 = (gcnew System::Windows::Forms::Label());
			this->caixaDecimalToHexadecima = (gcnew System::Windows::Forms::TextBox());
			this->label11 = (gcnew System::Windows::Forms::Label());
			this->caixaPointer2 = (gcnew System::Windows::Forms::TextBox());
			this->label12 = (gcnew System::Windows::Forms::Label());
			this->caixaFinal = (gcnew System::Windows::Forms::TextBox());
			this->label13 = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(24, 139);
			this->button1->Margin = System::Windows::Forms::Padding(6, 6, 6, 6);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(399, 244);
			this->button1->TabIndex = 0;
			this->button1->Text = L"CONVERTER";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Form1::Button1_Click);
			// 
			// txtN
			// 
			this->txtN->Location = System::Drawing::Point(24, 48);
			this->txtN->Margin = System::Windows::Forms::Padding(6, 6, 6, 6);
			this->txtN->Name = L"txtN";
			this->txtN->Size = System::Drawing::Size(396, 31);
			this->txtN->TabIndex = 1;
			this->txtN->Text = L"255";
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(18, 17);
			this->label1->Margin = System::Windows::Forms::Padding(6, 0, 6, 0);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(87, 25);
			this->label1->TabIndex = 2;
			this->label1->Text = L"Número";
			// 
			// txtOctalToDecimal
			// 
			this->txtOctalToDecimal->Location = System::Drawing::Point(494, 139);
			this->txtOctalToDecimal->Margin = System::Windows::Forms::Padding(6, 6, 6, 6);
			this->txtOctalToDecimal->Name = L"txtOctalToDecimal";
			this->txtOctalToDecimal->Size = System::Drawing::Size(396, 31);
			this->txtOctalToDecimal->TabIndex = 1;
			// 
			// txtHexadecimalToDecimal
			// 
			this->txtHexadecimalToDecimal->Location = System::Drawing::Point(494, 252);
			this->txtHexadecimalToDecimal->Margin = System::Windows::Forms::Padding(6, 6, 6, 6);
			this->txtHexadecimalToDecimal->Name = L"txtHexadecimalToDecimal";
			this->txtHexadecimalToDecimal->Size = System::Drawing::Size(396, 31);
			this->txtHexadecimalToDecimal->TabIndex = 1;
			// 
			// txtBinaryToDecimal
			// 
			this->txtBinaryToDecimal->Location = System::Drawing::Point(494, 48);
			this->txtBinaryToDecimal->Margin = System::Windows::Forms::Padding(6, 6, 6, 6);
			this->txtBinaryToDecimal->Name = L"txtBinaryToDecimal";
			this->txtBinaryToDecimal->Size = System::Drawing::Size(396, 31);
			this->txtBinaryToDecimal->TabIndex = 1;
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(488, 17);
			this->label2->Margin = System::Windows::Forms::Padding(6, 0, 6, 0);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(176, 25);
			this->label2->TabIndex = 3;
			this->label2->Text = L" binário->decimal";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(488, 108);
			this->label3->Margin = System::Windows::Forms::Padding(6, 0, 6, 0);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(151, 25);
			this->label3->TabIndex = 3;
			this->label3->Text = L"octal->decimal";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(488, 222);
			this->label4->Margin = System::Windows::Forms::Padding(6, 0, 6, 0);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(226, 25);
			this->label4->TabIndex = 3;
			this->label4->Text = L"hexadecimal->decimal";
			// 
			// txtDecToBinary
			// 
			this->txtDecToBinary->Location = System::Drawing::Point(494, 348);
			this->txtDecToBinary->Margin = System::Windows::Forms::Padding(6, 6, 6, 6);
			this->txtDecToBinary->Name = L"txtDecToBinary";
			this->txtDecToBinary->Size = System::Drawing::Size(396, 31);
			this->txtDecToBinary->TabIndex = 1;
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(488, 317);
			this->label5->Margin = System::Windows::Forms::Padding(6, 0, 6, 0);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(164, 25);
			this->label5->TabIndex = 3;
			this->label5->Text = L"decimal->binary";
			// 
			// caixaN
			// 
			this->caixaN->Location = System::Drawing::Point(494, 614);
			this->caixaN->Margin = System::Windows::Forms::Padding(6, 6, 6, 6);
			this->caixaN->Name = L"caixaN";
			this->caixaN->Size = System::Drawing::Size(396, 31);
			this->caixaN->TabIndex = 1;
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->Location = System::Drawing::Point(488, 583);
			this->label6->Margin = System::Windows::Forms::Padding(6, 0, 6, 0);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(338, 25);
			this->label6->TabIndex = 3;
			this->label6->Text = L"número: desta text para variável n";
			// 
			// label7
			// 
			this->label7->BackColor = System::Drawing::SystemColors::WindowText;
			this->label7->BorderStyle = System::Windows::Forms::BorderStyle::Fixed3D;
			this->label7->Location = System::Drawing::Point(26, 844);
			this->label7->Margin = System::Windows::Forms::Padding(6, 0, 6, 0);
			this->label7->Name = L"label7";
			this->label7->Size = System::Drawing::Size(868, 9);
			this->label7->TabIndex = 4;
			// 
			// label8
			// 
			this->label8->BackColor = System::Drawing::SystemColors::WindowText;
			this->label8->BorderStyle = System::Windows::Forms::BorderStyle::Fixed3D;
			this->label8->Location = System::Drawing::Point(24, 427);
			this->label8->Margin = System::Windows::Forms::Padding(6, 0, 6, 0);
			this->label8->Name = L"label8";
			this->label8->Size = System::Drawing::Size(868, 9);
			this->label8->TabIndex = 4;
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(26, 681);
			this->button2->Margin = System::Windows::Forms::Padding(6, 6, 6, 6);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(398, 44);
			this->button2->TabIndex = 5;
			this->button2->Text = L"Executar";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &Form1::Button2_Click);
			// 
			// caixaenderecoN
			// 
			this->caixaenderecoN->Location = System::Drawing::Point(494, 702);
			this->caixaenderecoN->Margin = System::Windows::Forms::Padding(6, 6, 6, 6);
			this->caixaenderecoN->Name = L"caixaenderecoN";
			this->caixaenderecoN->Size = System::Drawing::Size(396, 31);
			this->caixaenderecoN->TabIndex = 1;
			// 
			// label9
			// 
			this->label9->AutoSize = true;
			this->label9->Location = System::Drawing::Point(488, 672);
			this->label9->Margin = System::Windows::Forms::Padding(6, 0, 6, 0);
			this->label9->Name = L"label9";
			this->label9->Size = System::Drawing::Size(286, 25);
			this->label9->TabIndex = 3;
			this->label9->Text = L"endereço de n, declarada int";
			// 
			// caixaDecimal
			// 
			this->caixaDecimal->Location = System::Drawing::Point(494, 784);
			this->caixaDecimal->Margin = System::Windows::Forms::Padding(6, 6, 6, 6);
			this->caixaDecimal->Name = L"caixaDecimal";
			this->caixaDecimal->Size = System::Drawing::Size(396, 31);
			this->caixaDecimal->TabIndex = 1;
			// 
			// label10
			// 
			this->label10->AutoSize = true;
			this->label10->Location = System::Drawing::Point(488, 753);
			this->label10->Margin = System::Windows::Forms::Padding(6, 0, 6, 0);
			this->label10->Name = L"label10";
			this->label10->Size = System::Drawing::Size(223, 25);
			this->label10->TabIndex = 3;
			this->label10->Text = L"endereço em decimal ";
			// 
			// caixaDecimalToHexadecima
			// 
			this->caixaDecimalToHexadecima->Location = System::Drawing::Point(730, 884);
			this->caixaDecimalToHexadecima->Margin = System::Windows::Forms::Padding(6, 6, 6, 6);
			this->caixaDecimalToHexadecima->Name = L"caixaDecimalToHexadecima";
			this->caixaDecimalToHexadecima->Size = System::Drawing::Size(396, 31);
			this->caixaDecimalToHexadecima->TabIndex = 1;
			// 
			// label11
			// 
			this->label11->AutoSize = true;
			this->label11->Location = System::Drawing::Point(724, 853);
			this->label11->Margin = System::Windows::Forms::Padding(6, 0, 6, 0);
			this->label11->Name = L"label11";
			this->label11->Size = System::Drawing::Size(180, 25);
			this->label11->TabIndex = 3;
			this->label11->Text = L"de novo em Hexa";
			// 
			// caixaPointer2
			// 
			this->caixaPointer2->Location = System::Drawing::Point(730, 959);
			this->caixaPointer2->Margin = System::Windows::Forms::Padding(6, 6, 6, 6);
			this->caixaPointer2->Name = L"caixaPointer2";
			this->caixaPointer2->Size = System::Drawing::Size(396, 31);
			this->caixaPointer2->TabIndex = 1;
			// 
			// label12
			// 
			this->label12->AutoSize = true;
			this->label12->Location = System::Drawing::Point(724, 928);
			this->label12->Margin = System::Windows::Forms::Padding(6, 0, 6, 0);
			this->label12->Name = L"label12";
			this->label12->Size = System::Drawing::Size(261, 25);
			this->label12->TabIndex = 3;
			this->label12->Text = L"pointer 2 c esse endereço";
			// 
			// caixaFinal
			// 
			this->caixaFinal->Location = System::Drawing::Point(730, 1047);
			this->caixaFinal->Margin = System::Windows::Forms::Padding(6, 6, 6, 6);
			this->caixaFinal->Name = L"caixaFinal";
			this->caixaFinal->Size = System::Drawing::Size(396, 31);
			this->caixaFinal->TabIndex = 1;
			// 
			// label13
			// 
			this->label13->AutoSize = true;
			this->label13->Location = System::Drawing::Point(724, 1016);
			this->label13->Margin = System::Windows::Forms::Padding(6, 0, 6, 0);
			this->label13->Name = L"label13";
			this->label13->Size = System::Drawing::Size(219, 25);
			this->label13->TabIndex = 3;
			this->label13->Text = L"valor nesse endereço";
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(12, 25);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(922, 414);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->label8);
			this->Controls->Add(this->label7);
			this->Controls->Add(this->label13);
			this->Controls->Add(this->label12);
			this->Controls->Add(this->label11);
			this->Controls->Add(this->label10);
			this->Controls->Add(this->label9);
			this->Controls->Add(this->label6);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->txtBinaryToDecimal);
			this->Controls->Add(this->caixaFinal);
			this->Controls->Add(this->caixaPointer2);
			this->Controls->Add(this->caixaDecimalToHexadecima);
			this->Controls->Add(this->caixaDecimal);
			this->Controls->Add(this->caixaenderecoN);
			this->Controls->Add(this->caixaN);
			this->Controls->Add(this->txtDecToBinary);
			this->Controls->Add(this->txtHexadecimalToDecimal);
			this->Controls->Add(this->txtOctalToDecimal);
			this->Controls->Add(this->txtN);
			this->Controls->Add(this->button1);
			this->Margin = System::Windows::Forms::Padding(6, 6, 6, 6);
			this->Name = L"Form1";
			this->Text = L"Form1";
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
private: System::Void Button1_Click(System::Object^ sender, System::EventArgs^ e) {
		
	
	try
	{
		int bin = Convert::ToInt32(txtN->Text, 2);
		txtBinaryToDecimal->Text = Convert::ToString(bin);
	}
	catch (...)
	{
		txtBinaryToDecimal->Text = "Não Convertivel";
	}
	
	try
	{
		int oct = Convert::ToInt32(txtN->Text, 8);
		txtOctalToDecimal->Text = Convert::ToString(oct);
	}
	catch (...)
	{
		txtOctalToDecimal->Text = "Não Convertivel";
	}
	try
	{
		int hexad = Convert::ToInt32(txtN->Text, 16);
		txtHexadecimalToDecimal->Text = Convert::ToString(hexad);
	}
	catch (...)
	{
		txtHexadecimalToDecimal->Text = "Não Convertivel";
	}

	try
	{
		int deci = Convert::ToInt32(txtN->Text);
		txtDecToBinary->Text = Convert::ToString(deci, 2);
	}
	catch (...)
	{
		txtDecToBinary->Text = "Não convertível";
	}
}
	private: System::Void Form1_Load(System::Object^ sender, System::EventArgs^ e) {

	
	}
	private: System::Void Button2_Click(System::Object^ sender, System::EventArgs^ e)
	{
		


		


}
};
}
