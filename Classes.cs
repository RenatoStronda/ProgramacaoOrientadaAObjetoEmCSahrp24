namespace Classes{

public class pessoa{
    private string nome;
    private int idade;

public pessoa(string nome, int idade){
    this.nome = nome;
    this.idade = idade;
    }
public string getNome(){
    return this.nome;
    }
public void setNome(string nome){
    this.nome = nome;
}
public int getIdade(){
    return this.idade;
    }
public void setIdade(int idade){
    this.idade = idade;
    }
public int fazerAniversario(){
    return this.idade+1;
    }
 }
}