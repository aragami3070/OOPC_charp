namespace Extentions;
using Tables;

public static class Extention{
    public static void NegativeToZero(this Table table){
        if (table.PiTable != null){
            for (int i = 0; i < table.PiTable.Length; ++i){
                if (table.PiTable[i] < 0){
                    table.PiTable[i] = 0;
                }
            }
        }
        else{
            Console.WriteLine("Null Table");
        }
    }
}
