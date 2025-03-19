// See https://aka.ms/new-console-template for more information
class simpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;
    
    public simpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void printAllData()
    {
        for (int i = 0; i < storedData.Count; i++) { 
            Console.WriteLine("Data " + (i + 1) + " berisi " + storedData[i] + " , yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }


}
class Program
{
    public static void Main()
    {
        simpleDataBase<int> sgc = new simpleDataBase<int>();

        sgc.AddNewData(12);
        sgc.AddNewData(34);
        sgc.AddNewData(56);

        sgc.printAllData();
    }
}