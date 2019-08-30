using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    public class Moto {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;// opção melhor para não haver numeros negativos é utilizar o uint e não o int

        public Moto(string marca, string modelo, uint cilindrada) {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto() {

        }
        public string GetMarca() {
            return Marca;
        }
        public void SetMarca(string marca) {
            Marca = marca;
        }
        public string GetModelo() {
            return Modelo;
        }
        public void SetModelo(string modelo) {
            Modelo = modelo;
        }
        public uint GetCilindrada() {
            return Cilindrada;
        }
        public void SetCilindrada(uint cilindrada) {
            /* Primeira opção para não deixar valor negativo    
            *if(cilindrada > 0) {
            *   Cilindrada = cilindrada;
            *}
            */

            //segunda opção para deixar negativo, é utilizando o Absoluto, ou seja deixa todos valoes positivos
            //Cilindrada = Math.Abs(cilindrada);
            Cilindrada = cilindrada;
        }
    }
    class GetSet {
        public static void Executar() {
            var moto1 = new Moto("Kawasaki", "Ninja zx-6r", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);

            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());
            
        }
    }
}
