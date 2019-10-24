namespace CPUTest
{
    public class AddresBus 
    {
        private RAM ram; // Box of RAM data
        public AddresBus(RAM ram) // Copy of RAM
        {
            this.ram = ram;
        }
        public RAM GetRAM() // Getting of RAM
        {
            return ram;
        }
        public int AddresBusData() // Getting the addres of numberrs register
        {
            int a = ram.GetElementAddres();
            return a;
        }
    }
}
