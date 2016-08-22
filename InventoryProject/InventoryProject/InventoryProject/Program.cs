// IT Fdn Class Project Template.cs
// Write a program to keep track of some inventory items as shown below.
// Hint: when creating arrays, as you get or read items into
// your array, then initialize each array spot before its use
// and place a counter or use your own Mylength to keep track
// of your array length as it is used.

using System;
struct ItemData
{
    public int itemIDNo;
    public string sDescription;
    public double dblPricePerItem;
    public int iQuantityOnHand;
    public double dblOurCostPerItem;
    public double dblValueOfItem;

    public void add(int IDno, string sDes, double dblPrice, int iQOH, double dblCost)
    {
        itemIDNo = IDno;
        sDescription = sDes;
        dblPricePerItem = dblPrice;
        iQuantityOnHand = iQOH;
        dblOurCostPerItem = dblCost;
        dblValueOfItem = dblPrice * iQOH;
    }
}
class MyInventory
{
    public static void Main()
    {
        // use an interger to keep track of the count of items in your inventory					

        // create an array of your ItemData struct

        // use a never ending loop that shows the user what options they can select 

        // as long as no one Quits, continue the inventory update

        // in that loop, show what user can select from the list

        // read the user's input and then create what case it falls

        ItemData[] itemprop = new ItemData[10];

        int icount = 0;
        int optx = 1;

        while(optx != 0)
        {
            Console.WriteLine("1. Add an item");
            Console.WriteLine("2. Change an item");
            Console.WriteLine("3. Delete an item");
            Console.WriteLine("4. List all items in the database");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.Write("Please choose an option from the list(1,2,3,4, or 5): ");

            string strx = Console.ReadLine();   // read user's input	

            optx = int.Parse(strx); // convert the given string to integer to match our case types shown below

            Console.WriteLine(); // provide an extra blank line on screen

            switch (optx)
            {
                case 1: // add an item to the list if this option is 
                        // reset the count to show a new count for your list 
                        // (Note: your list is now increased by one item)
                    {
                        //the maximum number of item is 100.
                        if (icount > 100)
                        {
                            throw new IndexOutOfRangeException();
                        }
                        //resize the list by adding 10 more spaces when it reaches the capacity.
                        if (icount == itemprop.Length)
                        {
                            ItemData[] newItemProp = new ItemData[itemprop.Length + 10];
                            for (int i = 0; i < itemprop.Length; i++)
                            {
                                newItemProp[i] = itemprop[i];
                            }
                            itemprop = newItemProp;
                        }
                        Console.Write("Please enter item ID no.(3-digits)       :");
                        string strIDno = Console.ReadLine();
                        int iIDno = int.Parse(strIDno);
                        Console.Write("Please enter an item description(3 words):");
                        string strDes = Console.ReadLine();
                        Console.Write("Please enter item price($)               :");
                        string strPrice = Console.ReadLine();
                        double dblPrice = double.Parse(strPrice);
                        Console.Write("Please enter quantity on hand            :");
                        string strQOH = Console.ReadLine();
                        int iQOH = int.Parse(strQOH);
                        Console.Write("Please enter our item cost               :");
                        string strCost = Console.ReadLine();
                        double dblCost = double.Parse(strCost);
                        // use the method in struct
                        itemprop[icount++].add(iIDno, strDes, dblPrice, iQOH, dblCost);
                        Console.WriteLine();
                        break;
                    }

                case 2: //change items in the list if this option is selected
                    {
                        Console.Write("Please enter an item ID No:");
                        string strchgid = Console.ReadLine();
                        int chgid = int.Parse(strchgid);
                        bool fFound = false;

                        for (int x = 0; x < icount; x++)
                        {
                            if (itemprop[x].itemIDNo == chgid)
                            {
                                fFound = true;
                                // code to show what has to happen if the item in the list is found
                                // only change the properties of item, not the ID number.
                                Console.Write("Please enter an item description(3 words):");
                                string strDes = Console.ReadLine();
                                Console.Write("Please enter item price($)               :");
                                string strPrice = Console.ReadLine();
                                double dblPrice = double.Parse(strPrice);
                                Console.Write("Please enter quantity on hand            :");
                                string strQOH = Console.ReadLine();
                                int iQOH = int.Parse(strQOH);
                                Console.Write("Please enter our item cost               :");
                                string strCost = Console.ReadLine();
                                double dblCost = double.Parse(strCost);
                                itemprop[x].sDescription = strDes;
                                itemprop[x].dblPricePerItem = dblPrice;
                                itemprop[x].iQuantityOnHand = iQOH;
                                itemprop[x].dblOurCostPerItem = dblCost;
                                itemprop[x].dblValueOfItem = iQOH * dblCost;
                                Console.WriteLine();
                            }
                        }

                        if (!fFound) // and if not found
                        {
                            Console.WriteLine("Item {0} not found", chgid);
                            Console.WriteLine();
                        }

                        break;
                    }

                case 3: //delete items in the list if this option is selected
                    {
                        Console.Write("Please enter an item ID No:");
                        string strnewid = Console.ReadLine();
                        int newid = int.Parse(strnewid);
                        bool fDeleted = false;

                        for (int x = 0; x < icount; x++)
                        {
                            if (itemprop[x].itemIDNo == newid)
                            {
                                fDeleted = true;
                                // delete the item if you found it
                                // reset the count to show a new count for your list 
                                //(Note: your list is now reduced by one item)

                                itemprop.SetValue(null, x);
                                if (icount > 1)
                                    //in the case of the deletion of the first item in the list.
                                {
                                    int rest = icount - x - 1;
                                    if (rest !=0)
                                        //to move the rest of items behind the targeted item was located.
                                        //if the targeted item was at the end of the list, it passes the statement.
                                    {
                                        ItemData[] temp = new ItemData[rest];
                                        for (int j = 0; j < rest; j++)
                                        {
                                            temp[j] = itemprop[x + j + 1];
                                        }
                                        for (int i = 0; i < rest; i++)
                                        {
                                            itemprop[i + x] = temp[i];
                                        }
                                    }
                                }
                                icount--;
                                break;    //it stops when it completes to delete one item.
                                          // delete only first item even if multiple items have a same ID number.
                            }
                        }

                        if (fDeleted) // hint the user that you deleted the requested item
                        {
                            Console.WriteLine("Item deleted");
                            Console.WriteLine();
                        }
                        else // if did not find it, hint the user that you did not find it in your list
                        {
                            Console.WriteLine("Item {0} not found", newid);
                            Console.WriteLine();
                        }

                        break;
                    }

                case 4:  //list all items in current database if this option is selected
                    {
                        Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                        Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");

                        // code in this block. Use the above line format as a guide for printing or displaying the items in your list right under it
                        for (int x = 0; x < icount; x++)
                        {
                            Console.Write("{0,5}  ", x);
                            Console.Write("{0,6}  ", itemprop[x].itemIDNo);
                            Console.Write("{0,-20}  ", itemprop[x].sDescription);
                            Console.Write("{0,5:C}  ", itemprop[x].dblPricePerItem);
                            Console.Write("{0,3}  ", itemprop[x].iQuantityOnHand);
                            Console.Write("{0,4}  ", itemprop[x].dblOurCostPerItem);
                            Console.Write("{0,5:C}", itemprop[x].dblValueOfItem);
                            Console.WriteLine();
                        }
                        Console.WriteLine();

                        break;
                    }


                case 5: //quit the program if this option is selected
                    {
                        Console.Write("Are you sure that you want to quit(y/n)?");
                        string strresp = Console.ReadLine();

                        if (strresp.ToLower().Equals("y"))
                        {
                            optx = 0;   //as long as it is not 5, the process is not breaking	
                        }
                        Console.WriteLine();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Invalid Option, try again");
                        Console.WriteLine();
                        break;
                    }
            }
        }
    }
}