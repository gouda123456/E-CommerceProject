using E_CommerceProject.Busniss_Logic.IunitofWork.IRepo;
using E_CommerceProject.Data.Models;

namespace E_CommerceProject.Busniss_Logic.IunitofWork
{
    public class UnitofWork : IUnitofWork
    {
        public UnitofWork(database db, UserManager<User> manager)
        {
            this.AddressRepo = new Mainrepositry<Address>(db);
            this.BankFeeRepo = new Mainrepositry<BankFee>(db);
            this.CartRepo = new Mainrepositry<Cart>(db);
            this.CategoryRepo = new Mainrepositry<Category>(db);
            this.DiscountRepo = new Mainrepositry<Discount>(db);
            this.DiscountTypeRepo = new Mainrepositry<DiscountType>(db);
            this.OrderRepo = new Mainrepositry<Order>(db);
            this.OrderItemRepo = new Mainrepositry<OrderItem>(db);
            this.OrderStatusRepo = new Mainrepositry<OrderStatus>(db);
            this.PaymentDetailRepo = new Mainrepositry<PaymentDetail>(db);
            this.PaymentMethodRepo = new Mainrepositry<PaymentMethod>(db);
            this.PaymentStatusRepo = new Mainrepositry<PaymentStatus>(db);
            this.UserRepo = new UserRepositry(db, manager);
            //this.ProductRepo = new Mainrepositry<Product>(db);

        }

        private bool disposedValue;

        public IUserRepositry UserRepo { get; private set; }

        public IMainrepositry<Address> AddressRepo { get; private set; }

        public IMainrepositry<BankFee> BankFeeRepo { get; private set; }

        public IMainrepositry<Cart> CartRepo { get; private set; }

        public IMainrepositry<Category> CategoryRepo { get; private set; }

        public IMainrepositry<Discount> DiscountRepo { get; private set; }

        public IMainrepositry<DiscountType> DiscountTypeRepo { get; private set; }

        public IMainrepositry<Order> OrderRepo { get; private set; }

        public IMainrepositry<OrderItem> OrderItemRepo { get; private set; }

        public IMainrepositry<OrderStatus> OrderStatusRepo { get; private set; }

        public IMainrepositry<PaymentDetail> PaymentDetailRepo { get; private set; }

        public IMainrepositry<PaymentMethod> PaymentMethodRepo { get; private set; }

        public IMainrepositry<PaymentStatus> PaymentStatusRepo { get; private set; }

        public IMainrepositry<Product> ProductRepo => throw new NotImplementedException();

        public IMainrepositry<ProductImage> ProductImageRepo => throw new NotImplementedException();

        public IMainrepositry<Review> ReviewRepo => throw new NotImplementedException();

        public IMainrepositry<ShippingRegion> ShippingRegionRepo => throw new NotImplementedException();

        public IMainrepositry<StockMovement> StockMovementRepo => throw new NotImplementedException();

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UnitofWork()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
