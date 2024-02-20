// 18-09-2023
// Afonso Figueiredo
// Listas Ligadas



#include <iostream>
using namespace std;





//tipificação de struct para lista ligada





struct listaligada
{
	int numero;//a lista será ordenada por aqui
	int qualquercoisa; //item genérico; podia ser preço, idade, nome, etc...
	listaligada* proximo; //membro para apontador
};





listaligada* CABECA = NULL; //o primeiro da lista ou head (cabeça)
listaligada* CAUDA = NULL; //o último ou tail (cauda)





int main()
{



	//3 apontadores genéricos para struct:



	listaligada* novo; listaligada* atual; listaligada* anterior;



	//dados genéricos para o programa:



	char op; int n, qqc; bool existeNO; //membro 1 n=numero; membro2 qqc=qualquer coisa
	do
	{
		cout << "\n\nLISTA LIGADA-EXERCICIO DIDATICO (TRABALHO COOPERATIVO) ------------------------------------------\n";
		cout << "[1:listar]\n[2:insere primeiro]\n[3:insere no fim]\n[4:insere ao meio]\n[5:INSERE(completo)]" << "\n"
			<< "[6:remove cabeca]\n[7:remove cauda]\n[8:remove ao meio]\n[9:REMOVE (completo)]\n"
			<< "[a:limpa lista]\n[b:init lista com 3 nos]\n[c:lista ordenada? (sim/nao)]\n[d:ordena lista]\n[e:conta nos]\n"
			<< "[f:ler 2 nums; trocar os nos]\n[g:inverter a lista]\n[H: ler isto, por favor]\n[0:SAIR]\n"
			<< "Op? " << "\n";
		cin >> op;//MENU
		cout << "\n";
		switch (op)
		{
			// ---------------
		case 'i':
			anterior = CABECA;
			atual = (*anterior).proximo;
			bool NosIguais = false;
			listaligada* MaiorNo;

			do
			{

				if ( (*anterior).numero = (*atual).numero ) 
				{
					NosIguais = true;
						if (NosIguais == true)
						{
							if ((*anterior).qualquercoisa > (*atual).qualquercoisa)
							{
								MaiorNo = anterior;
							}
							else
							{
								MaiorNo = atual;
							}
							do
							{
								if (atual = MaiorNo)
								{
									(*anterior).proximo = (*atual).proximo;
									atual = NULL;
								}
								anterior = atual;
								atual = (*anterior).proximo;
							} while (atual != NULL);
						}
				}
				anterior = atual;
				atual = (*anterior).proximo;


			} while (atual != NULL);

			break;
			// --------------------------------------------------------------------------------------------------------------------- 1:LISTAR
		case '1':
			atual = CABECA;
			if (CABECA == NULL)
			{
				cout << "\n===============\n";
				cout << "Nao ha Listas";
				cout << "\n===============\n";
			}
			else
			{
				do
				{
					cout << "\n\n=====================================\n";
					cout << (*atual).numero << "\n";
					cout << (*atual).qualquercoisa << "\n";
					atual = (*atual).proximo;
					cout << "=========================================\n\n";

				} while (atual != NULL);
			}
			break;
			// ----------------------------------------------------------------------------------------------------------------------- 2:INSERIR CABEÇA
		case '2':

			// Inserir nova Cabeça

			atual = CABECA;

			novo = (struct listaligada*)malloc(sizeof(struct listaligada)); // Pedir Espaço
			CABECA = novo;
			(*novo).numero = 0;
			(*novo).qualquercoisa = 111;
			(*novo).proximo = atual;
			break;
			// --------------------------------------------------------------------------------------------------------------------- 3:INSERE NO FIM
		case '3':

			//	Inserir Nova CAUDA

			anterior = CAUDA;
			atual = CABECA;

			if (CAUDA == NULL)
			{
				novo = (struct listaligada*)malloc(sizeof(struct listaligada));//pedir espaço
				(*novo).numero = 10;
				(*novo).qualquercoisa = 101010;
				(*novo).proximo = NULL;
				(*atual).proximo = novo;
				CAUDA = novo;
			}
			else
			{
				novo = (struct listaligada*)malloc(sizeof(struct listaligada));//pedir espaço
				(*novo).numero = 10;
				(*novo).qualquercoisa = 101010;
				(*novo).proximo = NULL;
				(*anterior).proximo = novo;
				CAUDA = novo;
			}
			break;
			// --------------------------------------------------------------------------------------------------------------------- 4:INSERE AO MEIO
		case '4':

			anterior = (*CABECA).proximo;

			novo = (struct listaligada*)malloc(sizeof(struct listaligada));//pedir espaço
			(*CABECA).proximo = novo;
			(*novo).numero = 4;
			(*novo).qualquercoisa = 444;
			(*novo).proximo = anterior;
			break;
			// --------------------------------------------------------------------------------------------------------------------- 5:INSERE COMPLETO
		case '5':

			cout << "\n==============================\n";
			cout << "\nQual e a Posicao do No?\n";
			cin >> n;
			cout << "\nE Qualquer Coisa?\n";
			cin >> qqc;
			cout << "\n==============================\n";

			// Inserir CABEÇA

			if (CABECA == NULL) {
				atual = CABECA;
				novo = (struct listaligada*)malloc(sizeof(struct listaligada));//pedir espaco		
				(*novo).numero = n;
				(*novo).qualquercoisa = qqc;
				(*novo).proximo = atual;
				CABECA = novo;
			}
			else
			{
				if (n < (*CABECA).numero)
				{
					atual = CABECA;
					novo = (struct listaligada*)malloc(sizeof(struct listaligada));//pedir espaco		
					(*novo).numero = n;
					(*novo).qualquercoisa = qqc;
					(*novo).proximo = atual;
					CABECA = novo;
				}
				else if (n > (*CAUDA).numero)
				{
					atual = CAUDA;
					novo = (struct listaligada*)malloc(sizeof(struct listaligada));//pedir espaco		
					(*novo).numero = n;
					(*novo).qualquercoisa = qqc;
					(*novo).proximo = NULL;
					(*atual).proximo = novo;
					CAUDA = novo;
				}
				else
				{
					anterior = CABECA;
					atual = (*anterior).proximo;



					novo = (struct listaligada*)malloc(sizeof(struct listaligada));//pedir espaco		
					(*novo).numero = n;
					(*novo).qualquercoisa = qqc;



					while (atual != NULL)
					{
						if (n > (*anterior).numero && n < (*atual).numero) {



							(*anterior).proximo = novo;
							(*novo).proximo = atual;



						}
						anterior = (*anterior).proximo;
						atual = (*atual).proximo;
					}
				}
			}
			break;
			// --------------------------------------------------------------------------------------------------------------------- 6:REMOVE CABEÇA
		case '6':

			//Guardar Cabeça Antiga - Para poder fazer qqc

			anterior = CABECA;

			// Remover Cabeça

			novo = (*CABECA).proximo;
			CABECA = novo;

			break;
			// --------------------------------------------------------------------------------------------------------------------- 7:REMOVE CAUDA
		case '7':

			// Guardar Cabeça para ciclo. Atual toma o valor do nó a seguir da Cabeça.  

			anterior = CABECA;
			atual = (*anterior).proximo;

			// Ciclo Guardar nova Cauda

			while ((*atual).proximo != NULL)
			{
				anterior = atual;
				atual = (*atual).proximo;
			}

			// Atar Nó

			(*anterior).proximo = NULL;
			CAUDA = anterior;

			break;
			// --------------------------------------------------------------------------------------------------------------------- 8:REMOVE AO MEIO
		case '8':

			cout << "Escolha o No a Remover: ";
			cin >> n;
			existeNO = false;

			// Se a CABEÇA for NULL

			if (CABECA == NULL)
			{
				cout << "Nao existe Nos a remover!\n";
			}
			else
			{
				// Remover o MEIO

				anterior = CABECA;

				atual = (*anterior).proximo;

				while (atual != NULL && existeNO == false)
				{
					if (n == (*atual).numero) // Comparar com os Numeros do MEIO SÓ
					{
						// fazer andar ciclo

						(*anterior).proximo = (*atual).proximo;

						existeNO = true;
					}

					anterior = (*anterior).proximo; // ou anterior = atual;
					atual = (*atual).proximo;
				}
				if (existeNO == false)
				{
					cout << "\t===============================\n";
					cout << "\tNão existe o numero " << n << " no meio\n";
					cout << "=================================\n\n";
				}
			}
			break;
			// --------------------------------------------------------------------------------------------------------------------- 9:REMOVE COMPLETO
		case '9':

			// 4 Casos: 1º Caso: Lista Vazia / 2º Caso: Remover CABEÇA / 3º Caso: Remover CAUDA / 4º Caso: Remover MEIO

			// 1º Caso: Lista Vazia

			if (CABECA == NULL)
			{
				cout << "\n\n=======================";
				cout << "\nA lista esta Vazia";
				cout << "\n===========================\n\n";
			}
			else
			{
				cout << "Escolha o NO a Remover: ";
				cin >> n;

				// 2º Caso: Remover Cabeça

				if (n == (*CABECA).numero)
				{
					anterior = CABECA; // Guarda CABEÇA

					novo = ((*anterior).proximo); // Guarda endereço Nova CABEÇA
					CABECA = novo; // Define Nova CABEÇA
					free(anterior); // Libera CABEÇA
				}

				// 3º Caso: Remover CAUDA

				else if (n == (*CAUDA).numero)
				{
					anterior = CABECA; // Guarda CABEÇA para Ciclo

					while ( ((*anterior).proximo != CAUDA) ) // Ciclo para Guardar Anterior a CAUDA 
					{
						anterior = (*anterior).proximo; // Enquanto o Proximo do NÓ anterior for diferente do Nulo o Ciclo anda. Quando o Proximo do NÓ anterior for Igual a Cauda, ele guarda esse NÓ (anterior CAUDA)
					}

					free(CAUDA); // Libera CAUDA Antiga

					CAUDA = anterior; // Define Nova Cauda
					(*anterior).proximo = NULL; // Ata ultimo NÓ
				}

				// 4º Caso: Remove a MEIO

				else
				{
					existeNO = false; // bool para saber se Existe NÓ
					anterior = CABECA; // Guarda CABEÇA
					atual = (*anterior).proximo; // Guarda NÓ seguinte da CABEÇA

					while (atual != CAUDA && existeNO != true) // Se atual for Nulo quer dizer que o Proximo e a CAUDA
					{
						if (n == (*atual).numero)
						{
							(*anterior).proximo = (*atual).proximo; // Liga o contector do NÓ anterior ao do que se vai Eliminar ao NÓ do Proximo atual
							existeNO = true; // existe o NÓ
							free(atual); // libera o NÓ
						}

						// O Ciclo anda aos Pares

						anterior = (*anterior).proximo; // faz andar o ciclo
						atual = ( (*atual).proximo); // faz andar o ciclo
					}
					if (existeNO == false)
					{
						cout << "\n\n=======================================";
						cout << "\nNao Existe esse NO no meio da Lista\n";
						cout << "===========================================\n\n";
					}
				}
			}
			break;
			// --------------------------------------------------------------------------------------------------------------------- a:LIMPA LISTA
		case 'a':
			//limpar a lista de forma simples mas ineficiente:
			// /*CABECA = NULL;
			// CAUDA = NULL;*/


			//limpar a lista, libertando a memória dos nós:
			
			atual = CABECA;
			
			while (atual != NULL)
			{
				anterior = atual;//guarda o endereço que tem que ser libertado
				atual = (*atual).proximo;
				/*free(anterior);*///liberta o espaço reservado pelo malloc
			}

			// todos os nós foram libertados; há que recolocar as pontas:
			
			
			CABECA = NULL;
			CAUDA = NULL;
			break;
			// --------------------------------------------------------------------------------------------------------------------- b:INICIALIZA COM 3 NÓS "fixos"
		case 'b':

			//primeiro nó:

			novo = (struct listaligada*)malloc(sizeof(struct listaligada));//pedir espaço		
			CABECA = novo;
			(*novo).numero = 1;
			(*novo).qualquercoisa = 1111;
			(*novo).proximo = NULL;

			//segundo nó:

			novo = (struct listaligada*)malloc(sizeof(struct listaligada));//pedir espaço		
			(*CABECA).proximo = novo;
			(*novo).numero = 5;
			(*novo).qualquercoisa = 5555;
			(*novo).proximo = NULL;

			//terceiro nó:

			atual = novo; //para atar o último neste (novo vem de trás)
			novo = (struct listaligada*)malloc(sizeof(struct listaligada));//pedir espaço					
			(*atual).proximo = novo;
			(*novo).numero = 9;
			(*novo).qualquercoisa = 9999;
			(*novo).proximo = NULL;

			//antes de terminar, definir o último da lista:

			CAUDA = novo;

			break;
			// --------------------------------------------------------------------------------------------------------------------- c:LISTA ORDENADA? SIM/NÃO
		case 'c':



			break;
			// --------------------------------------------------------------------------------------------------------------------- d:ORDENA LISTA
		case 'd':



			break;
			// --------------------------------------------------------------------------------------------------------------------- e:CONTA NÓS
		case 'e':

			int contadorNos;
			atual = CABECA;

			contadorNos = 0;
			if (CABECA == NULL)
			{
				cout << "Nao ha Nos\n";
			}
			else
			{
				if ((*atual).proximo == NULL)
				{
					contadorNos = 1;
				}
				else
				{
					do
					{
						contadorNos++;
						atual = (*atual).proximo;

					} while (atual != NULL);
				}
			}
			
			cout << "\n\n====================================\n";
			cout << "A lista tem " << contadorNos << "\n";
			cout << "====================================\n\n";
			break;
			// --------------------------------------------------------------------------------------------------------------------- f:LER 2 NUMS; EXISTEM? TROCAR NÓS
		case 'f':


			break;
			// --------------------------------------------------------------------------------------------------------------------- g:INVERTER A LISTA
		case 'g':



			break;
			// --------------------------------------------------------------------------------------------------------------------- H:INVERTER A LISTA
		case 'H':
			cout << "\n\nEXERCICIO PRATICO COM LISTA LIGADA\nO objetivo e elaborar as opcoes 5 e 9.\nPara isso, comecar pelas mais simples:\n"
				<< "Exemplo: 2->3->4->5\n"
				<< "Sera pedido que alguns formandos facam as opcionais, para no final \njuntar tudo e o exercicio ficar completo."
				<< "\nNesse caso: respeitar a organizacao do codigo, nao usar funcoes, \ncomentar todas a linhas relevantes, identificar autor e data.\nObrigado. :)\n\n";
			break;
			// --------------------------------------------------------------------------------------------------------------------- 0:SAIR
		case '0':
			cout << "\n fim do programa...\n";
			break;
			// --------------------------------------------------------------------------------------------------------------------- DEFAULT
		default:
			cout << "\7"; //beep do sistema
			break;
		}
	} while (op != '0');
}