using System;
class Jogador {

  public string n;
  public string a;

  public string d;
  public int num;
  
  public string p;
  public bool s;


  public Jogador(){
    //é rodado toda vez que é criado um objeto da     classe jogador
    //numero++;
    s=true;
    num=11;
  }//void Jogador
  

public void exibe(string p,int num,string n,string a,string d,bool s){

    this.p=p;
    this.num=num;
    this.n=n;
    this.a=a;
    this.d=d;
    this.s=s;
  
    Console.Write(" "+p);
    Console.Write(" "+num);
    Console.Write(" - "+n);
    Console.Write(" ("+a+")");
    Console.Write(" - "+d);
    Console.WriteLine(" condição: "+s); 
  
}//void exibe
}//class Pessoa
class Helloword{
static void Main(){

int sair=1;
int op=0; 


        while(sair!=2){
            //mostrar menus ao entrar com as opções
            //sair, entrar, ver capacidade, add/entrada pessoa, tirar/saida pessoa, menu principal
            Console.WriteLine("\n ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ¬\n | Bem-vindo(a) ao clubinho de fut!\n | Montando partidade Futebol\n ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~\n");
            Console.WriteLine("Menu Principal, Opções:\n\n  1-Registrar time da casa\n 2-Registrar time visitante\n 3-Tirar time da casa\n 4-Tirar time visitante\n);

         

//ler a opção digitada pelo usuário
ocupar=Console.ReadLine();

//menu principal
switch(op){

case 1:
//fazer Registrar time da casa

  Console.WriteLine("Digite na seguinte ordem: \n");
  Console.WriteLine("--------------------\n Jogadores cadastrados: /n posição: - nome (apelido) - data nasc.dd/mm/aaaa condição: SUSPENSO/TÁ PRA JOGO \n--------------------\n");

  //função no main que cria Jogador jX =new Jogador();
  
  int numP=11
  string nomeOb;




  
  nomeOb=j+numP;//nome que tenho que dar ao criar um novo jogador da classe Jogador

  
  numP++;//somando 1
  nomeObj.num=numP;//atribuindo valor de numP na variavel num da classe Jogador
  
  
  
  Jogador nomeOb=new Jogador();
  nomeOb.exibe("Ataque",num,"Paulo","Lolo", "06/12/1989",false);
  
break; //case 1


case 2:
//fazer Registrar time visitante
break; //case 2

case 3:
//fazer Tirar time da casa
break; //case 3

case 4:
//fazer Tirar time visitante
break; //case 4
  

default:
Console.WriteLine("Opção inválida.\n Tente novamente."+"\n");
break;
}//switch op



//código do programa
  Jogador j1=new Jogador();
  Jogador j2=new Jogador();
  Jogador j3=new Jogador();
  Jogador j4=new Jogador();
  Jogador j5=new Jogador();
  Jogador j6=new Jogador();
  Jogador j7=new Jogador();
  Jogador j8=new Jogador();
  Jogador j9=new Jogador();
  Jogador j10=new Jogador();
  Jogador j11=new Jogador();
  Console.WriteLine("--------------------\n Jogadores cadastrados: /n posição: - nome (apelido) - data nasc.dd/mm/aaaa condição: SUSPENSO/TÁ PRA JOGO \n--------------------\n");
  j1.exibe("Goleiro",1,"Guilherme","Gui", "13/01/1987", true);
  j2.exibe("Zagueiro",2,"Bruno","Bruninho", "24/06/1975",false);
  j3.exibe("Meio-campo",3,"Theo","Te", "29/02/1984",false);  
  j4.exibe("Meio-campo",4,"Fernando","Nando", "24/09/1965",false);        
  j5.exibe("Zagueiro",5,"Wesley","Piolho", "24/06/1975",false);
  j6.exibe("Zagueiro",6,"Gabriel","Gabi", "14/10/1975",true);
  j7.exibe("Zagueiro",7,"Antonio","Toni", "08/04/1985",true);
  j8.exibe("Ataque",8,"Gabriel","Gael", "12/05/1979",false);
  j9.exibe("Ataque",9,"Ronaldo","Ronaldinho", "13/07/1986",false);
  j10.exibe("Ataque",10,"Neymar","Ney", "04/09/1981",true);        
  j11.exibe("Ataque",11,"Paulo","Lolo", "06/12/1989",false);
          

                      Console.WriteLine("Deseja sair? 1-Não 2-Sim");
            sair = Convert.ToInt16(Console.ReadLine());
            if (sair==2){
                //sair
                Console.WriteLine("Saindo...\n Encerrado."+"\n");
            }//if
            if (sair!=1 && sair!=2){
                //opção inválida: se sair não for 1-nao e se sair não for igual a 2-sim
                Console.WriteLine("Opção inválida.\n Tente novamente.");
            }//if
        }//while sair
          
}//static void
}//class helloword
