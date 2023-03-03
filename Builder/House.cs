using System;

namespace Builder
{
    public class House
    {
        public Foundation Foundation { get; private set; } 
        public Door Door { get; private set; }
        public Roof Roof { get; private set; }
        public Wall Wall { get; private set; }
        public Window Window { get; set; }
        private House()
        {

        }
        public static HouseBuilder Builder => new ();

        public class HouseBuilder
        {
            House house;
            public HouseBuilder()
            {
                house = new House();
            }
            public FoundationHouseBuilder AddFoundation(int square)
            {
                house.Foundation = new Foundation(square);
                return new FoundationHouseBuilder(house);
            }

            public class FoundationHouseBuilder
            {
                private House house;

                public FoundationHouseBuilder(House house)
                {
                    this.house = house;
                }

                public WallHouseBuilder AddWalls(int count)
                {
                    house.Wall = new Wall(count);
                    return new WallHouseBuilder(house);
                }

                public class WallHouseBuilder
                {

                    House house;
                    public WallHouseBuilder(House house)
                    {
                        this.house = house;
                    }
                    public RoofHouseBuilder AddRoof(string material)
                    {
                        house.Roof = new Roof(material);
                        return new RoofHouseBuilder(house);
                    }

                    public class RoofHouseBuilder
                    {
                        House house;
                        public RoofHouseBuilder(House house)
                        {
                            this.house = house;
                        }
                        public RoofHouseBuilder AddWindows(int count)
                        {
                            house.Window = new Window(count);
                            return this;
                        }
                        public RoofHouseBuilder AddDoor(int count,string material)
                        {
                            house.Door = new Door(count, material);
                            return this;
                        }
                        public House Build()
                        {
                            return house;
                        }
                    }
                }

            }
        }
    }

    
}
