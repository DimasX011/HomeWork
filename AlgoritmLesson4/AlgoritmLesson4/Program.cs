using System;

namespace AlgoritmLesson4
{
    class Program
    {
        static void Main(string[] args)
        {

            NodeInfo nod = new NodeInfo();
            nod.AddItem(65);
            nod.AddItem(21);
            nod.AddItem(86);
            nod.AddItem(45);
            nod.AddItem(17);
            nod.AddItem(26);
            nod.AddItem(118);
            nod.AddItem(211);
            nod.AddItem(90);

            nod.GetNodeByValue(118);
            nod.GetNodeByValue(90);
            nod.GetNodeByValue(17);
            nod.GetNodeByValue(26);
            nod.RemoveItem(45);

            Console.ReadLine();
        }
    }
}
