using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmLesson4
{
   public class NodeInfo : Itree
    {
        public int Depth { get; set; }
        public TreeNode Node { get; set; }

        public TreeNode Root { get; set; }

        public void AddItem(int value)//добавить узел
        {
            var newnode = new TreeNode {Value = value };
            if(Depth == 0)
            {
                newnode = Root;
                newnode.LeftChild = null;
                newnode.RightChild = null;
                Depth = 1;
                return;
            }
            else
            {
                Depth++;
                Console.WriteLine("Укажите правый или левый узел 1 - правый, 2- левый. ");
                string answ = Console.ReadLine();
                int answer = Convert.ToInt32(answ);
                if(answer == 1)
                {
                    Root.RightChild = newnode;
                    return;
                }
                Root.LeftChild = newnode;
                return;
            }
        }

        public TreeNode GetNodeByValue(int value)
        {
            throw new NotImplementedException();
        }

        public TreeNode GetRoot()//получение корневого узла
        {
            throw new NotImplementedException();
        }

        public void PrintTree()//распечатать дерево
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(int value)//удалить узел по значению
        {
            throw new NotImplementedException();
        }
    }
}
