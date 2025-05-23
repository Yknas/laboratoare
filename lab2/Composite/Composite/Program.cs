using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory mainRepo = new Directory("\nMainRepository");

            File src1 = new File("app.js");
            File src2 = new File("auth.js");
            File src3 = new File("utils.js");
            Directory srcDirectory = new Directory("src");

            File assets1 = new File("logo.png");
            File assets2 = new File("icon.svg");
            Directory assetsDirectory = new Directory("assets");

            File gitignore = new File(".gitignore");


            srcDirectory.AddComponent(src1);
            srcDirectory.AddComponent(src2);
            srcDirectory.AddComponent(src3);
            mainRepo.AddComponent(srcDirectory);

            assetsDirectory.AddComponent(assets1);
            assetsDirectory.AddComponent(assets2);
            mainRepo.AddComponent(assetsDirectory);

            mainRepo.AddComponent(gitignore);

            //assetsDirectory.RemoveComponent(assets1);

            mainRepo.Commit();
            mainRepo.Display();


        }
    }
}
