using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunCommandPattern();

            //RunAdapterPattern();

            //RunBridgePattern();

            //RunChainResposability();

            // RunRomanos();

            //RunBuilderPattern();

            //RunCompositePattern();

            //RunDecoratorPattern();
            RunFlyweightPattern();

            //RunFactoryPattern();

            Console.ReadKey();
        }
        private static void RunFlyweightPattern()
        {
            FlyweightPattern.Main flyweightPattern = new FlyweightPattern.Main();
            flyweightPattern.Run();
        }

        private static void RunCompositePattern()
        {
            CompositePattern.Main compositePattern = new CompositePattern.Main();
            compositePattern.Run();
        }

        //private static void RunFactoryPattern()
        //{
        //    FactoryPattern.Main factoryPattern = new FactoryPattern.Main();
        //    factoryPattern.Run();
        //}

        private static void RunDecoratorPattern()
        {
            DecoratorPattern.Main decoratorPattern = new DecoratorPattern.Main();
            decoratorPattern.Run();
        }

        public static void RunBuilderPattern()
        {
            BuilderPattern.Main builderPattern = new BuilderPattern.Main();
            builderPattern.Run();
        }

        public static void RunChainResposability()
        {
            ChainOfReponsabilityPattern.Main chainPattern = new ChainOfReponsabilityPattern.Main();
            chainPattern.Run();
        }
        public static void RunAdapterPattern()
        {
            AdapterPattern.Main adapterPattern = new AdapterPattern.Main();
            adapterPattern.Run();
        }

        public static void RunBridgePattern()
        {
            BridgePattern.Main bridgePattern = new BridgePattern.Main();
            bridgePattern.Run();
        }

        public static void RunCommandPattern()
        {
            string[] args = new string[] { "UpdateQuantity", "19" };
            CommandPattern.CommandProgramClient commandDesign = new CommandPattern.CommandProgramClient();
            commandDesign.Run(args);
        }
    }
}
