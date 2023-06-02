int count = 0;
int distance = 50000;
int firstFriendSpeed = 3;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;

int time;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
        count++;
    }
    else if (friend == 2)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
        count++;
    }
}
    Console.WriteLine($"Собака пробежит {count} раз.");


