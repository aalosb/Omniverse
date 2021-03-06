﻿using System.ComponentModel;
using System.Configuration;
using System.IO;
using static Kefka.Utilities.Constants;

namespace Kefka.Models
{
    public class ViviSettingsModel : BaseModel
    {
        private static ViviSettingsModel _instance;
        public static ViviSettingsModel Instance => _instance ?? (_instance = new ViviSettingsModel());

        private ViviSettingsModel() : base(@"Settings/" + Me.Name + "/Kefka/Routine Settings/Vivi/Vivi_Settings.json")
        {
        }

        private bool _useEnochian, _useBuffs, _useSharpcast, _useAoE, _useDpsPotion, _useSwiftcast, _useDoTs, _useOpener, _useLeyLines, _useDiversion, _useDefensives, _useConvert, _useVirus, _useScathe, _useDrain, _useTriplecast;

        private bool _showEnochian, _showBuffs, _showSharpcast, _showAoE, _showDpsPotion, _showSwiftcast, _showDoTs, _showOpener, _showLeyLines, _showDiversion, _showDefensives, _showConvert, _showVirus, _showScathe, _showDrain, _showTriplecast;

        private int _enoRfshPct, _thunderRfsh, _astralRfsh, _mobCount, _mpLimit, _mpTickMaxDelay, _mpMinPct, _selfHealPct;

        public void Load(string path)
        {
            if (File.Exists(path))
            {
                LoadFrom(path);
            }
        }

        [Setting]
        [DefaultValue(true)]
        public bool UseEnochian
        { get { return _useEnochian; } set { _useEnochian = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool UseBuffs
        { get { return _useBuffs; } set { _useBuffs = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool UseSharpcast
        { get { return _useSharpcast; } set { _useSharpcast = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(false)]
        public bool UseAoE
        { get { return _useAoE; } set { _useAoE = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(false)]
        public bool UseDpsPotion
        { get { return _useDpsPotion; } set { _useDpsPotion = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool UseDiversion
        { get { return _useDiversion; } set { _useDiversion = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool UseSwiftcast
        { get { return _useSwiftcast; } set { _useSwiftcast = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool UseLeyLines
        { get { return _useLeyLines; } set { _useLeyLines = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(false)]
        public bool UseOpener
        { get { return _useOpener; } set { _useOpener = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(30)]
        public int EnoRfshPct
        { get { return _enoRfshPct; } set { _enoRfshPct = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(6000)]
        public int ThunderRfsh
        { get { return _thunderRfsh; } set { _thunderRfsh = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(4000)]
        public int AstralRfsh
        { get { return _astralRfsh; } set { _astralRfsh = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool UseDefensives
        { get { return _useDefensives; } set { _useDefensives = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool UseDoTs
        { get { return _useDoTs; } set { _useDoTs = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool UseConvert
        { get { return _useConvert; } set { _useConvert = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(3)]
        public int MobCount
        { get { return _mobCount; } set { _mobCount = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(false)]
        public bool UseVirus
        { get { return _useVirus; } set { _useVirus = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(30)]
        public int MpLimit
        { get { return _mpLimit; } set { _mpLimit = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool ShowEnochian
        { get { return _showEnochian; } set { _showEnochian = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool ShowBuffs
        { get { return _showBuffs; } set { _showBuffs = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool ShowSharpcast
        { get { return _showSharpcast; } set { _showSharpcast = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool ShowAoE
        { get { return _showAoE; } set { _showAoE = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool ShowDpsPotion
        { get { return _showDpsPotion; } set { _showDpsPotion = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool ShowDiversion
        { get { return _showDiversion; } set { _showDiversion = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool ShowSwiftcast
        { get { return _showSwiftcast; } set { _showSwiftcast = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool ShowLeyLines
        { get { return _showLeyLines; } set { _showLeyLines = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool ShowOpener
        { get { return _showOpener; } set { _showOpener = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool ShowDefensives
        { get { return _showDefensives; } set { _showDefensives = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool ShowDoTs
        { get { return _showDoTs; } set { _showDoTs = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool ShowConvert
        { get { return _showConvert; } set { _showConvert = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool ShowVirus
        { get { return _showVirus; } set { _showVirus = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool UseScathe
        { get { return _useScathe; } set { _useScathe = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool ShowScathe
        { get { return _showScathe; } set { _showScathe = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(3000)]
        public int MpTickMaxDelay
        { get { return _mpTickMaxDelay; } set { _mpTickMaxDelay = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(75)]
        public int MpMinPct
        { get { return _mpMinPct; } set { _mpMinPct = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(60)]
        public int SelfHealPct
        { get { return _selfHealPct; } set { _selfHealPct = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool UseDrain
        { get { return _useDrain; } set { _useDrain = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool ShowDrain
        { get { return _showDrain; } set { _showDrain = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool UseTriplecast
        { get { return _useTriplecast; } set { _useTriplecast = value; OnPropertyChanged(); } }

        [Setting]
        [DefaultValue(true)]
        public bool ShowTriplecast
        { get { return _showTriplecast; } set { _showTriplecast = value; OnPropertyChanged(); } }
    }
}