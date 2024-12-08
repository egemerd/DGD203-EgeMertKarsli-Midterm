using exercise;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static Character name;
    static Character age;
    static Character gender;

    
    private static void Main(string[] args)
    {
        Character myCharacter = GetUserInput();


        
        ChooseRace(myCharacter);
        ShowCharacter(myCharacter);
        StoryStart(myCharacter);

        

        if (myCharacter.race == "Torriens")
        {
            StoryArcTorriens(myCharacter);

        }

        if (myCharacter.race == "Robiens")
        {
            StoryArcRobiens(myCharacter);
        }
        



        
        
    }

    public static Character GetUserInput()
    {
        Character character = new Character();
        Console.WriteLine("Write your characters name:");
        character.name = Console.ReadLine();
        Console.WriteLine("Enter your age:");
        character.age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Write your characters gender. \nType 1 for Male \nType 2 for Female \nType 3 for Others.");
        int gender_num = Convert.ToInt32(Console.ReadLine());
        switch (gender_num)
        {
            case 1:
                character.gender = "Male";
                
                break;
            case 2:
                character.gender = "Female";
                break;
            case 3:
                character.gender = "Others";
                break;
            default:
                Console.WriteLine("You made a invalid choose.");
                character.gender = "Unkown";
                break;
        }

        return character;

        

    }

    public static void ChooseRace(Character character)
    {
        bool loop_checker = true;
        while (loop_checker==true)
        {
            int race_num;
            Console.WriteLine($"\n{character.name}: This world has two races: Torriens and Robiens. Torriens excel in creativity, farming, and politics, while Robiens are skilled soldiers and engineers, masters of weapons and defense.");
            Console.WriteLine("Type 1 for choosing Torriens. \nType 2 for choosing Robiens.");
            race_num = Convert.ToInt32(Console.ReadLine());

            switch (race_num)
            {
                case 1:
                    character.race = "Torriens";
                    loop_checker = false;
                    break;
                case 2:
                    character.race = "Robiens";
                    loop_checker = false;
                    break;
                default:
                    Console.WriteLine("\nYou give invalid answer.");
                    break;
            }
        }
    }
    public static void ShowCharacter(Character character)
    {
        Console.WriteLine($"\nCharacter Details:\nName: {character.name}\nAge: {character.age}\nGender: {character.gender}\nRace: {character.race}");
        Console.WriteLine(name);
        Console.ReadLine();
    }

    public static void StoryStart(Character character)
    {
        Console.WriteLine($"\nYou have chosed {character.race}.");
        Console.WriteLine($"You are the head of {character.race}");
        Console.WriteLine("\nWhen a mysterious blue meteor strikes their land, harmony between two different races—the militaristic and highly developed Robiens and the imaginative and enterprising Torriens—is put to the test. \nThe meteor has a strong energy source that can influence how their world develops in the future. ");
        Console.WriteLine("However, its arrival coincides with a growing threat: a massive mountain on the horizon is becoming increasingly unstable, threatening all life.");
;       
    }
    public static void StoryArcTorriens(Character character)
    {
        bool loopchecker1 = true;
        int case_num = 0;
        int case_num2 = 0;
        int choose_num1;
        bool whichchoose = false;
        while (loopchecker1)
        {
            Console.WriteLine("\nElder: Ah, you're here. The arrival of the meteor has divided our people. \nSome believe its energy can save us from the mountain’s wrath, while others fear it will bring only destruction. \nWe need someone brave enough to decide our course. That person... is you.");

            Console.WriteLine("Type 1 to say: We must study the meteor and use its energy to save our people.");
            Console.WriteLine("Type 2 to say: It's too dangerous. We should destroy it before it destroys us.");
            choose_num1 = Convert.ToInt32(Console.ReadLine());
            switch (choose_num1)
            {
                case 1:
                    Console.WriteLine("We must study the meteor and use its energy to save our people.");
                    case_num = 1;
                    loopchecker1 = false;
                    break;
                case 2:
                    Console.WriteLine("It's too dangerous. We should destroy it before it destroys us.");
                    case_num = 2;
                    loopchecker1 = false;

                    break;
                default:
                    Console.WriteLine("You give an invalid answer.");
                    break;
            }
        }

        if (case_num == 1)
        {
            Console.WriteLine("\nYou chose to investigate the meteor.");
            Console.WriteLine("You assigned a village to take care of the investigation of the meteor.");
            Console.WriteLine("\nThis village contains some engineer from the Robiens. You have charge for all of them.");
            Console.WriteLine("During the meteor research, an accident occurs when one of the Robien engineers activates a device due to a miscalculation, causing an explosion. In the aftermath, some villagers and engineers are seriously injured.");
            
            ChooseBranch("Complete the Experiment, Put People at Risk.",
            "Halt the Experiment, Prioritize Safety",
            "To continue the research and gain valuable knowledge from the meteor, a particular experiment must be completed, which involves reactivating the device that caused the explosion. However, doing so will put the lives of the villagers and the research team at risk.",
            ref whichchoose);

            if (whichchoose ==true ) 
            {
                Console.WriteLine("After taking the risk to continue experimenting with the meteor, a catastrophic explosion occurs, severely injuring villagers and killing several engineers. Despite the immediate loss, the experiment reveals the true power of the meteor—its energy is both destructive and potentially world-altering. The explosion sets off a chain reaction, causing unstable shifts in the environment and triggering catastrophic events. As the world spirals toward its end, humanity is faced with the consequences of playing with forces they cannot control. The once vibrant world now faces destruction, and the choices made in the pursuit of knowledge have led to irreversible damage, bringing the world closer to its final days.");
                Console.ReadLine();
            }

            else 
            {
                Console.WriteLine("By choosing to protect the people and avoid risking the meteor, the research is halted. However, the mountain’s instability grows, and violent eruptions begin tearing the land apart. Tensions rise between the villagers and the Robbiens, as some blame you for not using the meteor's power. Despite your efforts, the world slowly succumbs to the mountain’s destruction, and humanity faces its inevitable end.");    
            
            }

        }

        if (case_num == 2)
        {
            Console.WriteLine("You decide the meteor is too dangerous and must be destroyed.  The elder frowns. It’s a difficult choice, but perhaps the safest one. You’ll need to organize a team to carry out the operation. Be careful—the Robbiens may not approve of this plan. ");
            Console.WriteLine("\nRobiens will be against of what you did");
            ChooseBranch("Persuade the villagers to support your decision.",
           "Proceed with the destruction despite their objections.",
           "\nAs you prepare for the mission, you encounter resistance from villagers who believe the meteor could save them.  ", ref whichchoose
           );
            
            if (whichchoose == true)
            {
                Console.WriteLine("\nYou choose to listen to the village. The mission contunies and you have a agreement with the Robiens. The process of destroy is began.");
                Console.WriteLine("\nAfter successfully convincing the villagers to destroy the meteor, you organize a mission to obliterate it. As the explosion takes place, the mountain quiets, and the villagers breathe a sigh of relief. But then, something unexpected happens—the energy released from the meteor forms a massive shockwave, temporarily destabilizing the area.");
                Console.WriteLine("\nDespite the shockwave, the destruction of the meteor proves to be the right choice. The villagers recover quickly, and the mountain remains calm. The Robiens grudgingly accept your decision, understanding the risk was too great. Tensions remain, but the immediate crisis is over. You, as a leader, gain the respect of both sides, and peace is restored—for now. However, some still wonder what might have happened if they had studied the meteor’s energy.");
            }

            else
            {
                Console.WriteLine("You chose to not listen to the village. Village became angry after that you ignore them. After rejecting the villagers’ pleas to preserve the meteor, they grow resentful and turn to the Robiens for support. ");
                ChooseBranch("Choose War",
                    "Choose Diplomacy",
                    "\nTensions rise as the Robiens, seeing an opportunity, begin to challenge your authority. The delicate balance between the two races is on the verge of collapse. You must decide the fate of this conflict.",
                    ref whichchoose);
                if (whichchoose == true)
                {
                    Console.WriteLine("The Torriens rally their forces, preparing for an inevitable clash with the Robiens. The battle is swift and brutal, with both sides suffering heavy losses. Though you manage to secure the meteor, the cost is devastating—your people are divided, and trust is shattered. The mountain’s wrath grows fiercer, and the once-united land falls into chaos, leaving you to wonder if the conflict was worth the price.");

                }

                else 
                {
                    Console.WriteLine("You reach out to the Robiens, proposing a truce. After tense negotiations, both sides agree to a compromise: the meteor will be studied by a joint task force of Torriens and Robiens under strict oversight. This cooperation rekindles hope between the two races, setting an example of unity in the face of disaster. While the mountain still looms ominously, your decision paves the way for a stronger, more harmonious future.");
                }
            }

        }

    }   


    public static void StoryArcRobiens(Character character) 
    {
        bool loopchecker1 = true;
        int case_num = 0;
        int case_num2 = 0;
        int choose_num1;
        bool whichchoose = false;
        while (loopchecker1)
        {
            Console.WriteLine("\n Commander, the meteor’s energy is dangerous. It could be our greatest weapon—or our end. The Torriens want to study it, but it’s a risk we can’t ignore. Do we secure it or destroy it? ");

            Console.WriteLine("Type 1 to say: We must study the meteor and use its energy to save our people.");
            Console.WriteLine("Type 2 to say: It's too dangerous. We should destroy it before it destroys us.");
            choose_num1 = Convert.ToInt32(Console.ReadLine());
            switch (choose_num1)
            {
                case 1:
                    Console.WriteLine("We must study the meteor and make a weapon with it.");
                    case_num = 1;
                    loopchecker1 = false;
                    break;
                case 2:
                    Console.WriteLine("It's too dangerous. We should destroy it before it destroys us.");
                    case_num = 2;
                    loopchecker1 = false;

                    break;
                default:
                    Console.WriteLine("You give an invalid answer.");
                    break;
            }

            if (case_num == 1) 
            {
                Console.WriteLine("\nYou chose to make a weapon with it. There will be a phase of investigating the meteor and making a weapon.");
                Console.WriteLine("The Torriens not will be happy about it for it's consequinces.");

                ChooseBranch("Lie them about dropping the investment and contunie it. So you can have the power without their knowledge.",
                    "Drop the investment.",
                    "\nAfter the Robbiens decide to weaponize the meteor, the Torriens rise in opposition, arguing that such power should not be controlled by any one faction. Tensions escalate, and you are faced with a critical decision.",
                    ref whichchoose);

                if (whichchoose == true)
                {
                    Console.WriteLine("You contunied the investment. You gained power from it to make superiority on the Torriens");

                    ChooseBranch("Use your power to fight with them",
                    "Convince them to use the power against The Mountain.",
                    "\nThe Torriens find out what you have done. They're angry and want you to take the punishment.",
                    ref whichchoose);

                    if (whichchoose==true) 
                    {
                        Console.WriteLine("The Robbiens harness the meteor's energy, forging it into an unstoppable weapon. With overwhelming strength, they crush the Torriens' resistance, forcing their submission. The power of the meteor then turns to the mountain, shattering its core and halting its destructive growth.\r\n\r\nThough the mountain's collapse causes widespread devastation, the Robbiens adapt and rebuild, using the meteor’s energy to stabilize the world. The scars of their conquest remain, but their dominion brings an era of enforced order. The world survives, reshaped by Robbien ingenuity and unyielding resolve.");
                    }

                    else 
                    {
                        Console.WriteLine("The Robbiens secretly weaponize the meteor, despite promising the Torriens they wouldn’t. When the Torriens uncover the deception, tensions rise, threatening to ignite a war.\r\n\r\nIn a desperate bid to avoid conflict, the Robbiens reveal their true intentions: to protect both races from the mountain's growing threat. Through earnest negotiation and assurances of shared control, they manage to regain the Torriens' trust.\r\n\r\nTogether, the two factions combine their strengths to harness the meteor’s energy, stabilizing the mountain and preserving their world. Though scars of betrayal linger, unity prevails, and a fragile peace begins to take root.");
                    }
                }
                else 
                { 
                    Console.WriteLine("You dropped the investment and the power of the mountain contunies to evolve. It becomes a huge threat for the both of the races. But it will be to late to come from there because you don't have enough time to use the power of the meteor. So the world is crushed by the power of the mountain.");
                }
            }

            if (choose_num1 == 2) 
            {
                Console.WriteLine("The Robbiens’ attempt to destroy the meteor backfires as their weapons destabilize it, triggering the mountain’s collapse. The resulting destruction spreads across the land, bringing the world to the brink of ruin.\r\n\r\nWith the planet fractured and time running out, the Robbiens are left to face the consequences of their actions, their ambition having sealed the fate of all.");
            }
        }
    }

    public static void ChooseBranch(string choose1,string choose2 ,string npctalk,ref bool whichchoose)
    {
        bool loopchecker1 = true;
        
        int choose_num1;
        
        while (loopchecker1)
        {
            Console.WriteLine(npctalk);

            Console.WriteLine($"Type 1 to say: {choose1}");
            Console.WriteLine($"Type 2 to say: {choose2}");
            choose_num1 = Convert.ToInt32(Console.ReadLine());
            switch (choose_num1)
            {
                case 1:
                    Console.WriteLine(choose1);
                    loopchecker1 = false;
                    whichchoose = true;
                    break;
                case 2:
                    Console.WriteLine(choose2);
                    loopchecker1 = false;
                    whichchoose = false;
                    break;
                default:
                    Console.WriteLine("You give an invalid answer.");
                    break;
            }
        }
    }

    

    


}