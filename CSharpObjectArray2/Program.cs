using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public interface Bonus
{
    string HaeAsiakas(string name, Asiakas asiakkaat);
    string LaskeBonus();
}
public class Asiakas: Bonus{
    string name_;
    int unit_;

public Asiakas(string name, int unit){
    name_ = name;
    unit_ = unit;
}

~Asiakas(){}

public string HaeAsiakas(string name_, Asiakas asiakkaat){
    string compare = "Teppo"; // Compare name with compare variable 
    if(asiakkaat.name_ != compare){
            return ("");
        }else{
            return (name_ + ", " + unit_);
    }
}
    public string LaskeBonus(){
        if(unit_ > 2000){
            double product = unit_ * 0.05;
            string data_bonus1 = Convert.ToString(product);//5% bonus
            return(data_bonus1);

        }else{
            double product1 = unit_ * 0.02;
            string data_bonus2 = Convert.ToString(product1);
            return(data_bonus2);

        }
            
    }    
}




    class Program
    {
        static void Main(string[] args)
        {
            Asiakas [] asiakkaat = new Asiakas[3];
            asiakkaat[0] = new Asiakas("Jari", 300) ;
            asiakkaat[1] = new Asiakas("Teppo", 3900);
            asiakkaat[2] = new Asiakas("Johanna", 2200);

            for(int i = 0; i< asiakkaat.Length; i++){
                Console.WriteLine(asiakkaat[i].HaeAsiakas("Teppo", asiakkaat[i]));
                Console.WriteLine(asiakkaat[i].LaskeBonus());
            }
    }

}

