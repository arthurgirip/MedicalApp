using MedicalApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp.DAL.Interfaces
{
    public interface IUser
    {
        List<User> ReadAllUsers();
        User ReadByUid(Guid userUid);
        void Create(User user);
        void Update(User user);
        void Delete(Guid userUid);
    }
}
