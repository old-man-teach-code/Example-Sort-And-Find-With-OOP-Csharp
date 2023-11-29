using System;
using System.Collections.Generic;

public class User
{
    // Properties
    public string Name { get; set; }
    public double LastMonthWaterMeter { get; set; }
    public double ThisMonthWaterMeter { get; set; }
    public string UserType { get; set; }
    public double TotalBill { get; private set; }

    // Constructor
    public User(string name, double lastMonthWaterMeter, double thisMonthWaterMeter, string userType)
    {
        Name = name;
        LastMonthWaterMeter = lastMonthWaterMeter;
        ThisMonthWaterMeter = thisMonthWaterMeter;
        UserType = userType;
    }

    // hàm tính tiền nước theo số nước tiêu thụ
    public void CalculateWaterBill()
    {
        // TODO: tính tiền nước
    }

    // hàm tính số nước tiêu thụ
    public double getWaterConsumption()
    {
        // TODO: tính số nước tiêu thụ và trả về giá trị
        return 0; // giá trị trả về tạm thời là 0, sinh viên cần thay đổi
    }
}



class Program
{
    static void Main()
    {
        // Tạo danh sách users
        List<User> users = new List<User>();

        // Add ví dụ 1 vài user vào danh sách
        users.Add(new User("Alice", 100, 150, "residential"));
        users.Add(new User("Bob", 200, 250, "commercial"));
        users.Add(new User("Charlie", 150, 180, "residential"));
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Before sorting:");
        // Hiển thị danh sách users
        foreach (var user in users)
        {
            Console.WriteLine($"Name: {user.Name}, Last Month: {user.LastMonthWaterMeter}, This Month: {user.ThisMonthWaterMeter}, " +
                              $"Type: {user.UserType}, Consumption: {user.getWaterConsumption()}, Total Bill: {user.TotalBill}");
        }

        Console.WriteLine("-------------------------------------");

        // Săp xếp danh sách users theo thứ tự tăng dần của chỉ số nước tiêu thụ tháng trước
        BubbleSortUsersByLastMonthWaterMeter(users);

        Console.WriteLine("\nAfter sorting:");
        // Hiển thị danh sách users sau khi sắp xếp
        foreach (var user in users)
        {
            Console.WriteLine($"Name: {user.Name}, Last Month: {user.LastMonthWaterMeter}, This Month: {user.ThisMonthWaterMeter}, " +
                              $"Type: {user.UserType}, Consumption: {user.getWaterConsumption()}, Total Bill: {user.TotalBill}");
        }

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Enter a name to search: ");
        string keyword = Console.ReadLine();

        List<User> foundUsers = FindUsersByName(users, keyword);

        foreach (var user in foundUsers)
        {
            Console.WriteLine($"Name: {user.Name}, Last Month: {user.LastMonthWaterMeter}, This Month: {user.ThisMonthWaterMeter}, " +
                              $"Type: {user.UserType}, Consumption: {user.getWaterConsumption()}, Total Bill: {user.TotalBill}");
        }

    }

    // Hàm sắp xếp danh sách users theo thứ tự tăng dần của chỉ số nước tiêu thụ tháng trước (LastMonthWaterMeter) Sử dụng thuật toán Bubble Sort
    static void BubbleSortUsersByLastMonthWaterMeter(List<User> users)
    {
        int n = users.Count;
        User temp;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (users[j].LastMonthWaterMeter > users[j + 1].LastMonthWaterMeter)
                {
                    // Hoán đổi 2 phần tử
                    temp = users[j];
                    users[j] = users[j + 1];
                    users[j + 1] = temp;
                }
            }
        }
    }

    // Hàm tìm kiếm user theo tên
    static List<User> FindUsersByName(List<User> users, string keyword)
    {
        return users.Where(user => user.Name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
    }

    // thuật toán Selection Sort (sắp xếp chọn) sắp xếp danh sách users theo thứ tự tăng dần của chỉ số nước tiêu thụ tháng trước (LastMonthWaterMeter)
    static void SelectionSortUsersByLastMonthWaterMeter(List<User> users)
    {
        int n = users.Count;

        for (int i = 0; i < n - 1; i++)
        {
            // Find the minimum element in unsorted array
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (users[j].LastMonthWaterMeter < users[minIndex].LastMonthWaterMeter)
                {
                    minIndex = j;
                }
            }

            // Swap the found minimum element with the first element
            User temp = users[minIndex];
            users[minIndex] = users[i];
            users[i] = temp;
        }
    }
}


