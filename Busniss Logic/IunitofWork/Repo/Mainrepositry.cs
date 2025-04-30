using E_CommerceProject.Busniss_Logic.IunitofWork.IRepo;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System;
using E_CommerceProject.Data;

namespace E_CommerceProject.Busniss_Logic.IunitofWork.Repo
{
    public class Mainrepositry<mdl> : IMainrepositry<mdl> where mdl : class
    {

        public Mainrepositry(database context)
        {
            this.context = context;
        }

        protected database context;

        public mdl FindById(int id)
        {
            return context.Set<mdl>().Find(id);
        }

        public mdl SelectOne(Expression<Func<mdl, bool>> match)
        {
            return context.Set<mdl>().SingleOrDefault(match);
        }

        public IEnumerable<mdl> FindAll()
        {
            return context.Set<mdl>().ToList();
        }

        public async Task<mdl> FindByIdAsync(int id)
        {
            return await context.Set<mdl>().FindAsync(id);
        }

        public async Task<IEnumerable<mdl>> FindAllAsync()
        {
            return await context.Set<mdl>().ToListAsync();
        }

        public IEnumerable<mdl> FindAll(params string[] agers)
        {
            IQueryable<mdl> query = context.Set<mdl>();

            if (agers.Length > 0)
            {
                foreach (var ager in agers)
                {
                    query = query.Include(ager);
                }
            }

            return query.ToList();
        }

        public async Task<IEnumerable<mdl>> FindAllAsync(params string[] agers)
        {
            IQueryable<mdl> query = context.Set<mdl>();

            if (agers.Length > 0)
            {
                foreach (var ager in agers)
                {
                    query = query.Include(ager);
                }
            }

            return await query.ToListAsync();
        }

        //=========================================================================//

        public void AddOne(mdl myItem)
        {
            context.Set<mdl>().Add(myItem);
            context.SaveChanges();
        }

        public void UpdateOne(mdl myItem)
        {
            context.Set<mdl>().Update(myItem);
            context.SaveChanges();
        }

        public void DeleteOne(mdl myItem)
        {
            context.Set<mdl>().Remove(myItem);
            context.SaveChanges();
        }

        public void AddList(IEnumerable<mdl> myList)
        {
            context.Set<mdl>().AddRange(myList);
            context.SaveChanges();
        }

        public void UpdateList(IEnumerable<mdl> myList)
        {
            context.Set<mdl>().UpdateRange(myList);
            context.SaveChanges();
        }

        public void DeleteList(IEnumerable<mdl> myList)
        {
            context.Set<mdl>().RemoveRange(myList);
            context.SaveChanges();
        }

    }
}
