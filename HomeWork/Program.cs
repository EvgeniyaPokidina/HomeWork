using HomeWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;




List<User> users = new List<User>()
{
    new User(1, "Ivan","Ivanov","ivan@mail.ru",45),

    new User(2, "Sam","Petrov","sam@mail.ru",33),
    new User(3,"Tom","Fedorov","tom@mail.ru",27),

};
using (DataBaseContext context = new DataBaseContext())
{
    context.AddRange(users);
    context.SaveChanges();
}