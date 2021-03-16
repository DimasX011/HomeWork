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

        public TreeNode descendant { get; set; }
        public void AddItem(int value)//добавить узел
        {
            var newnode = new TreeNode {Value = value };
            if(Root == null)
            {
                Root = newnode;
                descendant = Root;
                return;
            }
            else
            {
                var nextdesc = Root;
                if (newnode.Value < nextdesc.Value)//лево
                {
                    while (nextdesc.LeftChild != null)
                    {
                        if (newnode.Value > nextdesc.LeftChild.Value)
                        {
                            nextdesc = nextdesc.LeftChild;
                            if (nextdesc.RightChild == null)
                            {
                                nextdesc.RightChild = newnode;
                                descendant = nextdesc.RightChild;
                                return;
                            }
                            while (nextdesc.RightChild != null)
                            {
                                nextdesc = nextdesc.RightChild;
                                if (nextdesc.Value > newnode.Value)
                                {
                                    if (nextdesc.LeftChild == null)
                                    {
                                        nextdesc.LeftChild = newnode;
                                        descendant = nextdesc.LeftChild;
                                        return;
                                    }
                                    while (nextdesc.LeftChild != null)
                                    {
                                        nextdesc = nextdesc.LeftChild;
                                    }
                                    nextdesc.LeftChild = newnode;
                                    descendant = nextdesc.LeftChild;
                                    return;
                                }
                            }
                            nextdesc.RightChild = newnode;
                            descendant = nextdesc.RightChild;
                            return;
                        }
                        nextdesc = nextdesc.LeftChild;
                        if(nextdesc == null)
                        {
                            continue;
                        }
                    }
                    if (newnode.Value < nextdesc.Value)
                    {
                        nextdesc.LeftChild = newnode;
                        descendant = nextdesc.LeftChild;
                        return;
                    }
                }
                if (newnode.Value > nextdesc.Value)//право
                {
                    while (nextdesc.RightChild != null)
                    {
                        if (newnode.Value < nextdesc.RightChild.Value)
                        {
                            nextdesc = nextdesc.RightChild;
                            if (nextdesc.LeftChild == null)
                            {
                                nextdesc.LeftChild = newnode;
                                descendant = nextdesc.LeftChild;
                                return;
                            }
                            while (nextdesc.LeftChild != null)
                            {
                                nextdesc = nextdesc.LeftChild;
                                if (nextdesc.Value > newnode.Value)
                                {
                                    if(nextdesc.RightChild == null)
                                    {
                                        nextdesc.RightChild = newnode;
                                        descendant = nextdesc.RightChild;
                                        return;
                                    }
                                    while (nextdesc.RightChild != null)
                                    {
                                        nextdesc = nextdesc.RightChild;
                                    }
                                    nextdesc.RightChild = newnode;
                                    descendant = nextdesc.RightChild;
                                    return;
                                }
                            }
                            nextdesc.LeftChild = newnode;
                            descendant = nextdesc.LeftChild;
                            return;
                        }
                        nextdesc = nextdesc.RightChild;
                        if (nextdesc == null)
                        {
                            continue;
                        }
                    }
                    if (newnode.Value > nextdesc.Value)
                    {
                        nextdesc.RightChild = newnode;
                        descendant = nextdesc.RightChild;
                        return;
                    }
                }
            }
        }

        public TreeNode GetNodeByValue(int value)
        {
            var newnode = new TreeNode { Value = value };
            var searchnode = Root;
            while(searchnode.Value!= newnode.Value)
            {
                while (newnode.Value > searchnode.Value)//право
                {
                    searchnode = searchnode.RightChild;
                    if (searchnode.Value == newnode.Value)
                    {
                        return searchnode;
                    }
                    while(searchnode.Value < newnode.Value)
                    {
                        searchnode = searchnode.RightChild;
                        if(searchnode.Value == newnode.Value)
                        {
                            return searchnode;
                        }
                        while (searchnode.Value > newnode.Value)
                        {
                            searchnode = searchnode.LeftChild;
                            if(searchnode.Value == newnode.Value)
                            {
                                return searchnode;
                            }
                        }
                    }
                }
                while (newnode.Value < searchnode.Value)//лево
                {
                    searchnode = searchnode.LeftChild;
                    if (searchnode.Value == newnode.Value)
                    {
                        return searchnode;
                    }
                    while (searchnode.Value < newnode.Value)
                    {
                        searchnode = searchnode.RightChild;
                        if (searchnode.Value == newnode.Value)
                        {
                            return searchnode;
                        }
                        while (searchnode.Value > newnode.Value)
                        {
                            searchnode = searchnode.LeftChild;
                            if (searchnode.Value == newnode.Value)
                            {
                                return searchnode;
                            }
                            while(searchnode.Value< newnode.Value)
                            {
                                searchnode = searchnode.RightChild;
                                if( searchnode.Value == newnode.Value)
                                {
                                    return searchnode;
                                }
                            }
                        }
                    }
                }
            }
            return null;
        }

        public TreeNode GetRoot()//получение корневого узла
        {
            return Root;
        }

        public void PrintTree()//распечатать дерево
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(int value)//удалить узел по значению
        {
            var newnode = GetNodeByValue(value);
            if( newnode.LeftChild == null)
            {
                newnode = newnode.RightChild;
                newnode.Value = newnode.RightChild.Value;
                
                return;
            }
            if(newnode.RightChild == null)
            {
                newnode = newnode.LeftChild;
                descendant = newnode;
                return;
            }
            if(newnode.RightChild== null||newnode.LeftChild == null)
            {
                newnode = null;
                descendant = newnode;
                return;
            }
        }
    }

       
      

        
       
        
    
}
