﻿using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace PortEngine
{
    public class StorylineAPI
    {
        public static bool StorylineStatus = Properties.Settings.Default.storylineStatus;
        public static bool IsHijack1Completed = Properties.Settings.Default.hijack1EventCompleted;
        public static bool IsChatter1Completed = Properties.Settings.Default.chatter1EventCompleted;
        public static string PlayerDisplayName = Properties.Settings.Default.userDisplayName;
        static BackgroundWorker WorkerBee = new BackgroundWorker();

        public static void StorylineState(bool IsStorylineEnabled)
        {
            StorylineStatus = IsStorylineEnabled;
        }

        public static void StartHijackEvent1(TextBox txtHijack1)
        {
            if (IsHijack1Completed == false)
            {
                txtHijack1.AppendText("PortOS is now booting..." + Environment.NewLine);
                Thread.Sleep(5000);
                txtHijack1.AppendText("SYSTEM ERROR: HIJACKED" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("Incoming connection..." + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("A.H.G is now connected..." + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("A.H.G: WHO ARE YOU???" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("A.H.G: HOW DID YOU FIND THIS OS?!?!?!?!?" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("A.H.G: SINCE YOU FOUND THIS COMPUTER" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("A.H.G: PREPARE FOR YOUR COMPUTER TO DIE!!!!!" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("A.H.G is deleting /sys/..." + Environment.NewLine);
                Thread.Sleep(1000);
                txtHijack1.AppendText("Incoming connection..." + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("??? is now Connected..." + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("???: Hey there! Let me help you…" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("??? interupted the deletion of /sys/" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("??? is restoring /sys/" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("A.H.G: GAH! I CAN’T DELETE ANYTHING" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("/sys/ is restored..." + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("A.H.G: WHO ARE YO-" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("A.H.G has been kicked by ???" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("A.H.G disconnected…" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("???: Sorry about that let me reveal myself..." + Environment.NewLine);
                Thread.Sleep(1000);
                txtHijack1.AppendText("??? is now known as Adam…" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("Adam: I am Adam and I am one of the developers of PortOS!" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("Adam: As you know, A.H.G is a group of hackers that destroys PortOS computers." + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("Adam: This computer will shortly reboot and redirected to the desktop…" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("Adam: Also make sure to open Chatter once you get to the desktop!" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("Adam disconnected..." + Environment.NewLine);
                Thread.Sleep(5000);
                txtHijack1.Clear();
                Thread.Sleep(2000);
                txtHijack1.AppendText("PortOS is now booting..." + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("GUI Driver has been found!" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("Starting Desktop..." + Environment.NewLine);
                Thread.Sleep(3000);
            }
            else
            {
                txtHijack1.AppendText("PortOS is now booting..." + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("GUI Driver has been found!" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack1.AppendText("Starting Desktop..." + Environment.NewLine);
                Thread.Sleep(3000);
            }
            
        }

        public static void StartChatterEvent1(TextBox txtSentMessageDump)
        {
            if (IsChatter1Completed == false)
            {
                txtSentMessageDump.AppendText("Adam has entered the channel..." + Environment.NewLine);
                Thread.Sleep(2000);
                txtSentMessageDump.AppendText("<Adam> Hey there user!" + Environment.NewLine);
                Thread.Sleep(2000);
                txtSentMessageDump.AppendText("<Adam> You need to set a name so I know who you are." + Environment.NewLine);
                Thread.Sleep(2000);
                txtSentMessageDump.AppendText("<Adam> Open the settings application to change your username using the intuitive interface presented to you." + Environment.NewLine);
                Thread.Sleep(10000);
                txtSentMessageDump.AppendText("<Adam> Great!" + Environment.NewLine);
                Thread.Sleep(2000);
                txtSentMessageDump.AppendText("<Adam> Hello, " + PlayerDisplayName + Environment.NewLine);
                Thread.Sleep(2000);
                txtSentMessageDump.AppendText("<Adam> If you open your app launcher, there is an application called the 'QuantumNet Browser'" + Environment.NewLine);
                Thread.Sleep(2000);
                txtSentMessageDump.AppendText("<Adam> The QuantumNet is not a normal type of internet connection." + Environment.NewLine);
                Thread.Sleep(2000);
                txtSentMessageDump.AppendText("<Adam> It protects your privacy and has custom web-pages." + Environment.NewLine);
                Thread.Sleep(2000);
                txtSentMessageDump.AppendText("<Adam> Think of it like the deep web, but, deeper." + Environment.NewLine);
                Thread.Sleep(2000);
                txtSentMessageDump.AppendText("<Adam> It does not use the normal domains used with the World Wide Web, it uses specially formatted domains." + Environment.NewLine);
                Thread.Sleep(2000);
                txtSentMessageDump.AppendText("<Adam> Your computer seems to come with the best subscription out there of the QuantumNet. To check your subscription information, open the QuantumNet browser and type 'qt.quantumisp/home'" + Environment.NewLine);
                Thread.Sleep(15000);
                txtSentMessageDump.AppendText("<Adam> The domain names are pretty much a mixed version of the ones you would see on the normal Internet." + Environment.NewLine);
                Thread.Sleep(2000);
                txtSentMessageDump.AppendText("<Adam> Now, I need to talk about security and power. These will be important things when you go on with your quests or future endeavors inside of the QuantumNet." + Environment.NewLine);
                Thread.Sleep(2000);
                txtSentMessageDump.AppendText("<Adam> Malwarebits is a very useful QuantumSite to visit. It will allow you to upgrade those things. To do this, head to 'qt.malwarebits/home'" + Environment.NewLine);
                Thread.Sleep(15000);
                txtSentMessageDump.AppendText("<Adam> To upgrade these, you will need to earn HackPoints. The easiest way to do this is to play games." + Environment.NewLine);
                Thread.Sleep(2000);
                txtSentMessageDump.AppendText("<Adam> Anyways, I will see you... later..." + Environment.NewLine);
                Thread.Sleep(2000);
                txtSentMessageDump.AppendText("<Adam> I need to work on... something else..." + Environment.NewLine);
                Thread.Sleep(2000);
                txtSentMessageDump.AppendText("Adam has disconnected from the channel. " + Environment.NewLine);
            }
            else
            {
                txtSentMessageDump.AppendText(PlayerDisplayName + " has entered the channel!");
            }
        }


    }
}
