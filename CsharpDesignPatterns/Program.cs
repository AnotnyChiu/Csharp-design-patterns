using CsharpDesignPatterns.Adapter;
using CsharpDesignPatterns.Bridge;
using CsharpDesignPatterns.Builder;
using CsharpDesignPatterns.ChainOfResponsibility;
using CsharpDesignPatterns.Composite;
using CsharpDesignPatterns.Decorator;
using CsharpDesignPatterns.Facade;
using CsharpDesignPatterns.Factory;
using CsharpDesignPatterns.Flyweight;
using CsharpDesignPatterns.Observer;
using CsharpDesignPatterns.Proxy;
using CsharpDesignPatterns.Repository;
using CsharpDesignPatterns.Singleton;
using CsharpDesignPatterns.State;
using CsharpDesignPatterns.Strategy;
using CsharpDesignPatterns.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to design pattern demo proj, " +
                "please specify which pattern's demo you want to see:");
            Console.WriteLine("---------------------------------------\n" +
                "1. Singleton pattern\n" +
                "2. Factory pattern\n" +
                "3. Template Method pattern\n" +
                "4. Adapter pattern\n" +
                "5. Facade pattern\n" +
                "6. Strategy pattern\n" +
                "7. State pattern\n" +
                "8. Proxy pattern\n" +
                "9. Chain of Responsibility pattern\n" +
                "10. Bridge pattern\n" +
                "11. Composite pattern\n" +
                "12. Decorator pattern\n" +
                "13. Observer pattern\n" +
                "14. Builder pattern\n" +
                "15. Flyweight pattern\n" +
                "16. Repository pattern\n"
                );

            ExecutePattern(Console.ReadLine());

            Console.WriteLine("\n -----------------Finished-----------------");
            Console.WriteLine("press any key to quit");
            Console.ReadLine();
        }

        private static void ExecutePattern(string patternNo) 
        {
            switch (patternNo)
            {
                case "1":
                    Console.WriteLine("Your choose: Singleton pattern");
                    Console.WriteLine("------------------------------");
                    TestSingleton.SingletonMain();
                    break;
                case "2":
                    Console.WriteLine("Your choose: Factory pattern");
                    Console.WriteLine("------------------------------");
                    TestFactory.FactoryMain();
                    break;
                case "3":
                    Console.WriteLine("Your choose: Template Mothod pattern");
                    Console.WriteLine("------------------------------");
                    TestTemplateMethod.TestTemplate();
                    break;
                case "4":
                    Console.WriteLine("Your choose: Adapter pattern");
                    Console.WriteLine("------------------------------");
                    TestAdapter.AdapterMain();
                    break;
                case "5":
                    Console.WriteLine("Your choose: Facade pattern");
                    Console.WriteLine("------------------------------");
                    TestFacade.FacadeMain();
                    break;
                case "6":
                    Console.WriteLine("Your choose: Strategy pattern");
                    Console.WriteLine("------------------------------");
                    TestStrategy.StrategyMain();
                    break;
                case "7":
                    Console.WriteLine("Your choose: State pattern");
                    Console.WriteLine("------------------------------");
                    TestState.StateMain();
                    break;
                case "8":
                    Console.WriteLine("Your choose: Proxy pattern");
                    Console.WriteLine("------------------------------");
                    TestProxy.ProxyMain();
                    break;
                case "9":
                    Console.WriteLine("Your choose: Chain of Responsibility pattern");
                    Console.WriteLine("------------------------------");
                    TestChain.ChainResMain();
                    break;
                case "10":
                    Console.WriteLine("Your choose: Bridge pattern");
                    Console.WriteLine("------------------------------");
                    TestBridge.BridgeMain();
                    break;
                case "11":
                    Console.WriteLine("Your choose: Composite pattern");
                    Console.WriteLine("------------------------------");
                    TestComposite.CompositeMain();
                    break;
                case "12":
                    Console.WriteLine("Your choose: Decorator pattern");
                    Console.WriteLine("------------------------------");
                    TestDecorator.DecoratorMain();
                    break;
                case "13":
                    Console.WriteLine("Your choose: Observer pattern");
                    Console.WriteLine("------------------------------");
                    TestObserver.ObserverMain();
                    break;
                case "14":
                    Console.WriteLine("Your choose: Builder pattern");
                    Console.WriteLine("------------------------------");
                    TestBuilder.BuilderMain();
                    break;
                case "15":
                    Console.WriteLine("Your choose: Flyweight pattern");
                    Console.WriteLine("------------------------------");
                    TestFlyweight.FlyweightMain();
                    break;
                case "16":
                    Console.WriteLine("Your choose: Repository pattern");
                    Console.WriteLine("------------------------------");
                    TestRepository.RepositoryMain();
                    break;
                default:
                    Console.WriteLine("Please insert valid number (1 - 16)");
                    // use recursion to deal with wrong input
                    ExecutePattern(Console.ReadLine());
                    break;
            }
        }
    }
}
