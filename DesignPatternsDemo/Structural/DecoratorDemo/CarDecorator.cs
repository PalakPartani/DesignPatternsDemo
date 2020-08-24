namespace StructureDecoratorDemo
{
    public abstract class CarDecorator : ICar1
    {
        protected ICar1 car;
        public CarDecorator(ICar1 car)
        {
            this.car = car;
        }
        public virtual ICar1 ManufactureCar()
        {
            return car.ManufactureCar();
        }
    }
}
