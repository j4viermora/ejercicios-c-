using System;

class Electrodomesticos{

    private double precioBase {get; set;} = 100;
    private string color {get; set;} = "blanco";
    private char consumoEnergetico {get; set;} = 'F';
    private double peso {get; set;} = 5;

    public Electrodomesticos(){}

    public Electrodomesticos (double precio, double peso ){

        precio = this.precioBase;
        peso = this.peso;  
    }

    public Electrodomesticos (double precio, string color, char consumoEnergetico, double peso){

                precio = this.precioBase;
                color = this.color;
                consumoEnergetico = this.consumoEnergetico;
                peso = this.peso;
    }

        public double GetprecioBase(){

            return this.precioBase;
            
        }

        public string Getcolor(){
            return this.color;
        }

        public char GetconsumoEnergetico(){
            return this.consumoEnergetico;
        }

        public double Getpeso(){
            return this.peso;
        }

    private void comprobarConsumoEnergetico(char letra){

        if(Char.ToUpper(letra) == 'A' || Char.ToUpper(letra) == 'B' || Char.ToUpper(letra) == 'C' || Char.ToUpper(letra) == 'D' || Char.ToUpper(letra) == 'E' || Char.ToUpper(letra) == 'F'  ){

            this.consumoEnergetico = char.ToUpper(letra); 
        }
        else{this.consumoEnergetico = 'F';}
    }

    private void comprobarColor(String color){
        if(color.ToUpper() == "Blanco" || color.ToUpper() == "Negro" || color.ToUpper() == "Rojo" || color.ToUpper() == "Azul" || color.ToUpper() == "Gris"){
    
            this.color = color.ToUpper();
    } else { this.color = "Blanco"; this.color = this.color.ToUpper();}
    
}


    public double precioFinal()
        {
            double precioFinal = this.precioBase;

            
            switch (this.consumoEnergetico)
            {
                case 'A':
                    precioFinal += 100;  
                    break;
                case 'B':
                    precioFinal += 80;  
                    break;
                case 'C':
                    precioFinal += 60;  
                    break;
                case 'D':
                    precioFinal += 50;  
                    break;
                case 'E':
                    precioFinal += 30;  
                    break;
                case 'F':
                    precioFinal += 10;  
                    break;
            default: precioFinal += 5;   
                    break;
            }

            
            if (this.peso > 0 && this.peso <= 19)
            {
                precioFinal += 10;
            }
            else if (this.peso > 20 && this.peso <= 49)
            {
                precioFinal += 50;
            }
            else if(this.peso > 50 && this.peso <= 79)
            {
                precioFinal += 80; 
            }
            else if(this.peso > 80)
            {
                precioFinal += 100; 
            }

            return precioFinal;
        }
    }


class Lavadora : Electrodomesticos {

    private double carga {get; set;} = 5;
     public Lavadora

    
}

class Program
{
    public static void Main(string[] args)
    {



        
    }
}
