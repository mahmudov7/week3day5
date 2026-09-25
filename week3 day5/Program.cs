// List<int> numbers = new List<int>{1,1,1,1,1,1,1};
// List<int> ints = new List<int>{1,2,1,3,4,5};
// numbers.AddRange(ints);
// numbers.Sort();
// var a=numbers.Distinct().ToList();
// foreach (var item in a)
// {
//     System.Console.Write(item+" ");
// }
// task 2
// List <int> num = new List<int>{-3,2,2,4,5,1,-1};
// num.RemoveAll(a => a<0);

//task 3
// List<int> list1 = new List<int> { 9,6, 4, 5, 6, -1, 0, 0, 11, 1, 2, 3, 4, 5, 6, 4, 5, 6 };

// Random random = new Random();

// for (int i=0; i < list1.Count; i++) //5
// {
// int ind = random.Next(i, list1.Count - 1);
// int temp = 0; //0
// temp = list1[i]; // temp =, list1[i] = 0
// list1[i] = list1[ind]; // list1[i] = naprimer 6, list1[ind] = 0
// list1[ind] = temp; //list1[ind] =9,temp=0
// }
// foreach (var item in list1)
// {

// Console.Write(item +" ");
// }
//task 5
// List <string> nam = new List<string>{"ali", "alijon"};
// foreach (var item in nam)
// {
    // System.Console.Write(item+",");
// }
//task 6
// List<int> numbers = new List<int>{4,9,7,77,6,1};
// List<int> ints = new List<int>{1,2,4,5,2,3};
// numbers.AddRange(ints);
// numbers.Sort();
// var a=numbers.Distinct().ToList();
// foreach (var item in a)
// {
//     Console.Write(item+" ");
// }
//task 7
// List<int> Get(List<int> ints)
// {
//    return ints.Distinct().ToList();
// }
//  List<int> num = new List<int>{5,3,6,3,7,4,8,9};
// Get (num);
// foreach (var item in Get(num))
// {
//  System.Console.Write(item+" ");   
// }
//task 8
Rectangle rectangle1 = new Rectangle();
rectangle1.Width=12;
rectangle1.Height=2;
System.Console.WriteLine(rectangle1.ConculateArea());