using System;
public class Jogador{
  //atributos da classe jogador
  public int id;//não sei se vai precisar

  public  string n;
  public  string a;

  public  string d;
  public  int num; //camiseta

  public  string p; //matriz //goleiro,
  public  bool s;//se tiver 3 cartoes amarelos ou 1 cartao vermelho ou decisao judicial

  public  int qualidade;
  public  int cartoes;//amarelo e vermelho


  public Jogador(){//metodo principal
    //é rodado toda vez que é criado um objeto da     classe jogador
    //numero++;
    s=true;
    num=11;//ver se pode ser assim
  }//void Jogador

public void exibeJogador(string p,int num,string n,string a,string d,bool s){//int qualidade,int cartoes,
    this.p=p;
    this.num=num;
    this.n=n;
    this.a=a;
    this.d=d;
    this.s=s;
//this.qualidade=qualidade;
//this.cartoes=cartoes;
  
    Console.Write(" "+p);
    Console.Write(" "+num);
    Console.Write(" - "+n);
    Console.Write(" ("+a+")");
    Console.Write(" - "+d);
    Console.WriteLine(" condição: "+s); 
    Console.WriteLine("qualidade: "+qualidade);
    Console.WriteLine("cartoes: "+cartoes);
}//public void exibeJogador

public void casdastrarJogador(string n,string a,string d,int num,string p,bool s){/*int qualidade,int cartoes*/

  
  num=11;//ver se precisa disso
  //ler a opção digitada pelo usuário
  Console.WriteLine("\n Digite as informações do jogador na ordem que se pede: \n");
  Console.WriteLine("Posicao no campo: (aceitáveis: Ataque, Meio-campo, Goleiro, Zagueiro)");
  //posicao
  string pd="sim";
  if(pd=="sim"){//sempre vai cair aqui
    pd=Console.ReadLine();//ler posição q digitou
    if(pd=="Ataque"|pd=="ataque"|pd=="Meio-campo"|pd=="meio-campo"|pd=="Goleiro"|pd=="goleiro"|pd=="Zagueiro"|pd=="zagueiro"){
      //fazer
      p=pd;

      //num    é praser automático pensar como
      num++;

      Console.WriteLine("Nome: ");
        n=Console.ReadLine();

      Console.WriteLine("Apelido: ");
        a=Console.ReadLine();

      Console.WriteLine("Data Nasc: (aceitável digite dessa maneira: dd/mm/aaaa) ");
        d=Console.ReadLine();

      //s= não é aqui que vai ser determinar se está ou não suspenso isso vai ser uma condicional dos cartoes amarelos e vermelho


      pd="sim";
      if(pd=="sim"){//3//sempre vai cair aqui
        Console.WriteLine("Estão corretas as informações digitadas do jogador, abaixo:  sim/não \n");
        Console.WriteLine("Posicao no campo: "+p);
        Console.WriteLine("Nome: "+n);
        Console.WriteLine("Apelido: "+a);
        Console.WriteLine("Data Nasc: "+d);

        pd=Console.ReadLine();//sim vai if4 ou nao vai else4
        if(pd=="sim"){//4
          //this.variavel-da-classe=variavel-do-metodo
          this.p=p;
          this.num=num;
          this.n=n;
          this.a=a;
          this.d=d;
          this.s=s;
          //registrado com sucesso.
          Console.WriteLine("\n Registrado com sucesso."+"\n");
        }//if 4
        else{//4
          //ditou errado alguma info do jogador, tente novamente
          Console.WriteLine("\n Ok. Tente novamente."+"\n");
        }//else 4
      }//if 3
    }//if 2
    else{//2
      Console.WriteLine("Opção inválida.\n Tente novamente.\n");
    }//eslse 2
  }//if 1
}//cadastrarJogador

//método
//bool verificarCondicaoDeJogo()

//função estática com retorno
//static void verificarCondicaoDeJogo(){
//}//verificarCondicaoDeJogo


}//class Jogador

class Program{
static void Main(){

int sair=1;
int op; 




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
  j1.exibeJogador("Goleiro",1,"Guilherme","Gui", "13/01/1987", true);
  j2.exibeJogador("Zagueiro",2,"Bruno","Bruninho", "24/06/1975",false);
  j3.exibeJogador("Meio-campo",3,"Theo","Te", "29/02/1984",false);  
  j4.exibeJogador("Meio-campo",4,"Fernando","Nando", "24/09/1965",false);        
  j5.exibeJogador("Zagueiro",5,"Wesley","Piolho", "24/06/1975",false);
  j6.exibeJogador("Zagueiro",6,"Gabriel","Gabi", "14/10/1975",true);
  j7.exibeJogador("Zagueiro",7,"Antonio","Toni", "08/04/1985",true);
  j8.exibeJogador("Ataque",8,"Gabriel","Gael", "12/05/1979",false);
  j9.exibeJogador("Ataque",9,"Ronaldo","Ronaldinho", "13/07/1986",false);
  j10.exibeJogador("Ataque",10,"Neymar","Ney", "04/09/1981",true);        
  j11.exibeJogador("Ataque",11,"Paulo","Lolo", "06/12/1989",false);
  

        while(sair!=2){
            //mostrar menus ao entrar com as opções
            //sair, entrar, ver capacidade, add/entrada pessoa, tirar/saida pessoa, menu principal
            Console.WriteLine("\n ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ¬\n | Bem-vindo(a) ao clubinho de fut!\n | Montando partidade Futebol\n ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~\n");
            Console.WriteLine("Menu Principal, Opções:\n 1-Registrar Jogador: time da casa\n 2-Registrar Jogador: time visitante\n 3-Tirar Jogador: time da casa\n 4-Tirar Jogador: time visitante\n 5-Montar partida\n");
//ler a opção digitada pelo usuário
op=Convert.ToInt16(Console.ReadLine());

//menu principal
switch(op){

case 1:
//fazer Registrar jogador: time da casa

  Console.WriteLine("Digite na seguinte ordem: \n");
  Console.WriteLine("--------------------\n Jogadores cadastrados: \n posição: - nome (apelido) - data nasc.dd/mm/aaaa condição: SUSPENSO/TÁ PRA JOGO \n--------------------\n");

  
      int nump=11;
      string nomeOb;

      
      nump++;
      nomeOb="j"+nump;

      Console.WriteLine("nomeOb "+nomeOb);
      Console.WriteLine("nump "+nump);
  
  //-> Jogador nomeOb=new Jogador();
  //-> nomeOb.cadastrarJogador();
  
break; //case 1


case 2:
//fazer Registrar jogador: time visitante
break; //case 2

case 3:
//fazer Tirar jogador: time da casa
break; //case 3

case 4:
//fazer Tirar jogador: time visitante
break; //case 4

case 5:
//fazer Montar partida
break; //case 5
  

default:
Console.WriteLine("Opção inválida.\n Tente novamente."+"\n");
break;
}//switch op


          

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
}//class Program
