namespace ex06_properties
{
    class Kiturami
    {
        public int temperature; //  온도

        // Rosalyn VS 개발서포터

        public int Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                if (value < 10)
                {
                    temperature = 20; // 10도 이하는 허용안함
                }
                else if (value > 70)
                {
                    temperature = 50; // 70도 초과는 허용안함
                else
                        temperature = value;
                }
                temperature = value;
            }
        }

        //   public int SetTemperature(int temp)
        //   { 
        //       if (temp > 70)
        //       {
        //           Console.WriteLine("온도가 너무 높습니다. 50도로 조정합니다.");
        //           this.temperature = 50;
        //       }
        //       else if ( temp < 10 )
        //       {
        //           Console.WriteLine("온도가 너무 낮습니다. 20도로 조정합니다.");
        //           this.temperature = temp;
        //       }
        //       else
        //       {
        //          this.temperature = temp;
        //       }
        //        
        //   }

        public int GetTemperature() 
        { 
            return this.temperature;
        }
        public void On()
        {
            Console.WriteLine("보일러 On");
        }

        public void Off()
        {
            Console.WriteLine("보일러 Off");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("보일러 시작!");
            Kiturami boiler = new Kiturami();
            //boiler.temperature = 400; // 막아버림
            //Console.WriteLine($"보일러 온도는 {boiler.temperature}도"); // 막아버림
            //boiler.temperature = 400;
            //boiler.SetTemperature($"보일러 온도는 {boiler.GetTemperature()} 도");
            boiler.Temperature = 400;
            Console.WriteLine($"보일러 온도는 {boiler.GetTemperature()}도");
            boiler.On();
        }
    }
}
