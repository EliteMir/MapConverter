using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MapTileSet
{
    public partial class TfmMain : Form
    {
        public enum FileType
        {
            Back = 0,
            Middle = 1,
            Front = 2
        }

        public class FileEntry
        {
            public FileType fileType;
            public int OldIndex;
            public int NewIndex;
            public int Offset;
            public int NewImage;
        }

        public enum FileNames
        {
            WemadeMir2_Tiles = 0,
            WemadeMir2_Smtiles,
            WemadeMir2_Objects,
            WemadeMir2_Objects2,
            WemadeMir2_Objects3,
            WemadeMir2_Objects4,
            WemadeMir2_Objects5,
            WemadeMir2_Objects6,
            WemadeMir2_Objects7,
            WemadeMir2_Objects8,
            WemadeMir2_Objects9,
            WemadeMir2_Objects10,
            WemadeMir2_Objects11,
            WemadeMir2_Objects12,
            WemadeMir2_Objects13,
            WemadeMir2_Objects14,
            WemadeMir2_Objects15,
            WemadeMir2_Objects16,
            WemadeMir2_Objects17,
            WemadeMir2_Objects18,
            WemadeMir2_Objects19,
            WemadeMir2_Objects20,
            WemadeMir2_Objects21,
            WemadeMir2_Objects22,
            WemadeMir2_Objects23,
            WemadeMir2_Objects24,
            WemadeMir2_Objects25,
            WemadeMir2_Objects26,

            ShandaMir2_Tiles = 100,
            ShandaMir2_Tiles2,
            ShandaMir2_Tiles3,
            ShandaMir2_Tiles4,
            ShandaMir2_Tiles5,
            ShandaMir2_Tiles6,
            ShandaMir2_Tiles7,
            ShandaMir2_Tiles8,
            ShandaMir2_Tiles9,
            ShandaMir2_Tiles10,
            ShandaMir2_Tiles11,
            ShandaMir2_Tiles12,
            ShandaMir2_Tiles13,
            ShandaMir2_Tiles14,
            ShandaMir2_Tiles15,
            ShandaMir2_Tiles16,
            ShandaMir2_Tiles17,
            ShandaMir2_Tiles18,
            ShandaMir2_Tiles19,
            ShandaMir2_Tiles20,
            ShandaMir2_Tiles21,
            ShandaMir2_Tiles22,
            ShandaMir2_Tiles23,
            ShandaMir2_Tiles24,
            ShandaMir2_Tiles25,
            ShandaMir2_Tiles26,
            ShandaMir2_Tiles27,
            ShandaMir2_Tiles28,
            ShandaMir2_Tiles29,
            ShandaMir2_Tiles30,
            ShandaMir2_Tiles31,
            ShandaMir2_Tiles32,
            ShandaMir2_Tiles33,
            ShandaMir2_Tiles34,
            ShandaMir2_Tiles35,
            ShandaMir2_Tiles36,
            ShandaMir2_Tiles37,
            ShandaMir2_Tiles38,
            ShandaMir2_Tiles39,
            ShandaMir2_Tiles40,
            ShandaMir2_Tiles41,
            ShandaMir2_Tiles42,
            ShandaMir2_Tiles43,
            ShandaMir2_Tiles44,
            ShandaMir2_Tiles45,
            ShandaMir2_Tiles46,
            ShandaMir2_Tiles47,
            ShandaMir2_Tiles48,
            ShandaMir2_Tiles49,
            ShandaMir2_Tiles50,
            ShandaMir2_Tiles51,
            ShandaMir2_Tiles52,
            ShandaMir2_Tiles53,
            ShandaMir2_Tiles54,
            ShandaMir2_Tiles55,
            ShandaMir2_Tiles56,
            ShandaMir2_Tiles57,
            ShandaMir2_Tiles58,
            ShandaMir2_Tiles59,
            ShandaMir2_Tiles60,
            ShandaMir2_Tiles61,
            ShandaMir2_Tiles62,
            ShandaMir2_Tiles63,
            ShandaMir2_Tiles64,
            ShandaMir2_Tiles65,
            ShandaMir2_Tiles66,
            ShandaMir2_Tiles67,
            ShandaMir2_Tiles68,
            ShandaMir2_Tiles69,
            ShandaMir2_Tiles70,
            ShandaMir2_Tiles71,
            ShandaMir2_Tiles72,
            ShandaMir2_Tiles73,
            ShandaMir2_Tiles74,
            ShandaMir2_Tiles75,
            ShandaMir2_Tiles76,
            ShandaMir2_Tiles77,
            ShandaMir2_Tiles78,
            ShandaMir2_Tiles79,
            ShandaMir2_Tiles80,
            ShandaMir2_Tiles81,
            ShandaMir2_Tiles82,
            ShandaMir2_Tiles83,
            ShandaMir2_Tiles84,
            ShandaMir2_Tiles85,
            ShandaMir2_Tiles86,
            ShandaMir2_Tiles87,
            ShandaMir2_Tiles88,
            ShandaMir2_Tiles89,
            ShandaMir2_Tiles90,
            ShandaMir2_Tiles91,
            ShandaMir2_Tiles92,
            ShandaMir2_Tiles93,
            ShandaMir2_Tiles94,
            ShandaMir2_Tiles95,
            ShandaMir2_Tiles96,
            ShandaMir2_Tiles97,
            ShandaMir2_Tiles98,
            ShandaMir2_Tiles99,
            ShandaMir2_Tiles100,
            ShandaMir2_Tiles101,
            ShandaMir2_Tiles102,
            ShandaMir2_Tiles103,
            ShandaMir2_Tiles104,
            ShandaMir2_Tiles105,
            ShandaMir2_Tiles106,
            ShandaMir2_Tiles107,
            ShandaMir2_Tiles108,
            ShandaMir2_Tiles109,
            ShandaMir2_Tiles110,
            ShandaMir2_Tiles111,
            ShandaMir2_Tiles112,
            ShandaMir2_Tiles113,
            ShandaMir2_Tiles114,
            ShandaMir2_Tiles115,
            ShandaMir2_Tiles116,
            ShandaMir2_Tiles117,
            ShandaMir2_Tiles118,
            ShandaMir2_Tiles119,
            ShandaMir2_Tiles120,
            ShandaMir2_Tiles121,
            ShandaMir2_Tiles122,
            ShandaMir2_Tiles123,
            ShandaMir2_Tiles124,
            ShandaMir2_Tiles125,
            ShandaMir2_Tiles126,
            ShandaMir2_Tiles127,
            ShandaMir2_Tiles128,
            ShandaMir2_Tiles129,
            ShandaMir2_Tiles130,
            ShandaMir2_Tiles131,
            ShandaMir2_Tiles132,
            ShandaMir2_Tiles133,
            ShandaMir2_Tiles134,
            ShandaMir2_Tiles135,
            ShandaMir2_Tiles136,
            ShandaMir2_Tiles137,
            ShandaMir2_Tiles138,
            ShandaMir2_Tiles139,
            ShandaMir2_Tiles140,
            ShandaMir2_Tiles141,
            ShandaMir2_Tiles142,
            ShandaMir2_Tiles143,
            ShandaMir2_Tiles144,
            ShandaMir2_Tiles145,
            ShandaMir2_Tiles146,
            ShandaMir2_Tiles147,
            ShandaMir2_Tiles148,
            ShandaMir2_Tiles149,
            ShandaMir2_Tiles150,
            ShandaMir2_Tiles151,
            ShandaMir2_Tiles152,
            ShandaMir2_Tiles153,
            ShandaMir2_Tiles154,
            ShandaMir2_Tiles155,
            ShandaMir2_Tiles156,
            ShandaMir2_Tiles157,
            ShandaMir2_Tiles158,
            ShandaMir2_Tiles159,
            ShandaMir2_Tiles160,
            ShandaMir2_Tiles161,
            ShandaMir2_Tiles162,
            ShandaMir2_Tiles163,
            ShandaMir2_Tiles164,
            ShandaMir2_Tiles165,
            ShandaMir2_Tiles166,
            ShandaMir2_Tiles167,
            ShandaMir2_Tiles168,
            ShandaMir2_Tiles169,
            ShandaMir2_Tiles170,
            ShandaMir2_Tiles171,
            ShandaMir2_Tiles172,
            ShandaMir2_Tiles173,
            ShandaMir2_Tiles174,
            ShandaMir2_Tiles175,
            ShandaMir2_Tiles176,
            ShandaMir2_Tiles177,
            ShandaMir2_Tiles178,
            ShandaMir2_Tiles179,
            ShandaMir2_Tiles180,
            ShandaMir2_Tiles181,
            ShandaMir2_Tiles182,
            ShandaMir2_Tiles183,
            ShandaMir2_Tiles184,
            ShandaMir2_Tiles185,
            ShandaMir2_Tiles186,
            ShandaMir2_Tiles187,
            ShandaMir2_Tiles188,
            ShandaMir2_Tiles189,
            ShandaMir2_Tiles190,
            ShandaMir2_Tiles191,
            ShandaMir2_Tiles192,
            ShandaMir2_Tiles193,
            ShandaMir2_Tiles194,
            ShandaMir2_Tiles195,
            ShandaMir2_Tiles196,
            ShandaMir2_Tiles197,
            ShandaMir2_Tiles198,
            ShandaMir2_Tiles199,
            ShandaMir2_Tiles200,

            ShandaMir2_SmTiles = 300,
            ShandaMir2_SmTiles2,
            ShandaMir2_SmTiles3,
            ShandaMir2_SmTiles4,
            ShandaMir2_SmTiles5,
            ShandaMir2_SmTiles6,
            ShandaMir2_SmTiles7,
            ShandaMir2_SmTiles8,
            ShandaMir2_SmTiles9,
            ShandaMir2_SmTiles10,
            ShandaMir2_SmTiles11,
            ShandaMir2_SmTiles12,
            ShandaMir2_SmTiles13,
            ShandaMir2_SmTiles14,
            ShandaMir2_SmTiles15,
            ShandaMir2_SmTiles16,
            ShandaMir2_SmTiles17,
            ShandaMir2_SmTiles18,
            ShandaMir2_SmTiles19,
            ShandaMir2_SmTiles20,
            ShandaMir2_SmTiles21,
            ShandaMir2_SmTiles22,
            ShandaMir2_SmTiles23,
            ShandaMir2_SmTiles24,
            ShandaMir2_SmTiles25,
            ShandaMir2_SmTiles26,
            ShandaMir2_SmTiles27,
            ShandaMir2_SmTiles28,
            ShandaMir2_SmTiles29,
            ShandaMir2_SmTiles30,
            ShandaMir2_SmTiles31,
            ShandaMir2_SmTiles32,
            ShandaMir2_SmTiles33,
            ShandaMir2_SmTiles34,
            ShandaMir2_SmTiles35,
            ShandaMir2_SmTiles36,
            ShandaMir2_SmTiles37,
            ShandaMir2_SmTiles38,
            ShandaMir2_SmTiles39,
            ShandaMir2_SmTiles40,
            ShandaMir2_SmTiles41,
            ShandaMir2_SmTiles42,
            ShandaMir2_SmTiles43,
            ShandaMir2_SmTiles44,
            ShandaMir2_SmTiles45,
            ShandaMir2_SmTiles46,
            ShandaMir2_SmTiles47,
            ShandaMir2_SmTiles48,
            ShandaMir2_SmTiles49,
            ShandaMir2_SmTiles50,
            ShandaMir2_SmTiles51,
            ShandaMir2_SmTiles52,
            ShandaMir2_SmTiles53,
            ShandaMir2_SmTiles54,
            ShandaMir2_SmTiles55,
            ShandaMir2_SmTiles56,
            ShandaMir2_SmTiles57,
            ShandaMir2_SmTiles58,
            ShandaMir2_SmTiles59,
            ShandaMir2_SmTiles60,
            ShandaMir2_SmTiles61,
            ShandaMir2_SmTiles62,
            ShandaMir2_SmTiles63,
            ShandaMir2_SmTiles64,
            ShandaMir2_SmTiles65,
            ShandaMir2_SmTiles66,
            ShandaMir2_SmTiles67,
            ShandaMir2_SmTiles68,
            ShandaMir2_SmTiles69,
            ShandaMir2_SmTiles70,
            ShandaMir2_SmTiles71,
            ShandaMir2_SmTiles72,
            ShandaMir2_SmTiles73,
            ShandaMir2_SmTiles74,
            ShandaMir2_SmTiles75,
            ShandaMir2_SmTiles76,
            ShandaMir2_SmTiles77,
            ShandaMir2_SmTiles78,
            ShandaMir2_SmTiles79,
            ShandaMir2_SmTiles80,
            ShandaMir2_SmTiles81,
            ShandaMir2_SmTiles82,
            ShandaMir2_SmTiles83,
            ShandaMir2_SmTiles84,
            ShandaMir2_SmTiles85,
            ShandaMir2_SmTiles86,
            ShandaMir2_SmTiles87,
            ShandaMir2_SmTiles88,
            ShandaMir2_SmTiles89,
            ShandaMir2_SmTiles90,
            ShandaMir2_SmTiles91,
            ShandaMir2_SmTiles92,
            ShandaMir2_SmTiles93,
            ShandaMir2_SmTiles94,
            ShandaMir2_SmTiles95,
            ShandaMir2_SmTiles96,
            ShandaMir2_SmTiles97,
            ShandaMir2_SmTiles98,
            ShandaMir2_SmTiles99,
            ShandaMir2_SmTiles100,
            ShandaMir2_SmTiles101,
            ShandaMir2_SmTiles102,
            ShandaMir2_SmTiles103,
            ShandaMir2_SmTiles104,
            ShandaMir2_SmTiles105,
            ShandaMir2_SmTiles106,
            ShandaMir2_SmTiles107,
            ShandaMir2_SmTiles108,
            ShandaMir2_SmTiles109,
            ShandaMir2_SmTiles110,
            ShandaMir2_SmTiles111,
            ShandaMir2_SmTiles112,
            ShandaMir2_SmTiles113,
            ShandaMir2_SmTiles114,
            ShandaMir2_SmTiles115,
            ShandaMir2_SmTiles116,
            ShandaMir2_SmTiles117,
            ShandaMir2_SmTiles118,
            ShandaMir2_SmTiles119,
            ShandaMir2_SmTiles120,
            ShandaMir2_SmTiles121,
            ShandaMir2_SmTiles122,
            ShandaMir2_SmTiles123,
            ShandaMir2_SmTiles124,
            ShandaMir2_SmTiles125,
            ShandaMir2_SmTiles126,
            ShandaMir2_SmTiles127,
            ShandaMir2_SmTiles128,
            ShandaMir2_SmTiles129,
            ShandaMir2_SmTiles130,
            ShandaMir2_SmTiles131,
            ShandaMir2_SmTiles132,
            ShandaMir2_SmTiles133,
            ShandaMir2_SmTiles134,
            ShandaMir2_SmTiles135,
            ShandaMir2_SmTiles136,
            ShandaMir2_SmTiles137,
            ShandaMir2_SmTiles138,
            ShandaMir2_SmTiles139,
            ShandaMir2_SmTiles140,
            ShandaMir2_SmTiles141,
            ShandaMir2_SmTiles142,
            ShandaMir2_SmTiles143,
            ShandaMir2_SmTiles144,
            ShandaMir2_SmTiles145,
            ShandaMir2_SmTiles146,
            ShandaMir2_SmTiles147,
            ShandaMir2_SmTiles148,
            ShandaMir2_SmTiles149,
            ShandaMir2_SmTiles150,
            ShandaMir2_SmTiles151,
            ShandaMir2_SmTiles152,
            ShandaMir2_SmTiles153,
            ShandaMir2_SmTiles154,
            ShandaMir2_SmTiles155,
            ShandaMir2_SmTiles156,
            ShandaMir2_SmTiles157,
            ShandaMir2_SmTiles158,
            ShandaMir2_SmTiles159,
            ShandaMir2_SmTiles160,
            ShandaMir2_SmTiles161,
            ShandaMir2_SmTiles162,
            ShandaMir2_SmTiles163,
            ShandaMir2_SmTiles164,
            ShandaMir2_SmTiles165,
            ShandaMir2_SmTiles166,
            ShandaMir2_SmTiles167,
            ShandaMir2_SmTiles168,
            ShandaMir2_SmTiles169,
            ShandaMir2_SmTiles170,
            ShandaMir2_SmTiles171,
            ShandaMir2_SmTiles172,
            ShandaMir2_SmTiles173,
            ShandaMir2_SmTiles174,
            ShandaMir2_SmTiles175,
            ShandaMir2_SmTiles176,
            ShandaMir2_SmTiles177,
            ShandaMir2_SmTiles178,
            ShandaMir2_SmTiles179,
            ShandaMir2_SmTiles180,
            ShandaMir2_SmTiles181,
            ShandaMir2_SmTiles182,
            ShandaMir2_SmTiles183,
            ShandaMir2_SmTiles184,
            ShandaMir2_SmTiles185,
            ShandaMir2_SmTiles186,
            ShandaMir2_SmTiles187,
            ShandaMir2_SmTiles188,
            ShandaMir2_SmTiles189,
            ShandaMir2_SmTiles190,
            ShandaMir2_SmTiles191,
            ShandaMir2_SmTiles192,
            ShandaMir2_SmTiles193,
            ShandaMir2_SmTiles194,
            ShandaMir2_SmTiles195,
            ShandaMir2_SmTiles196,
            ShandaMir2_SmTiles197,
            ShandaMir2_SmTiles198,
            ShandaMir2_SmTiles199,
            ShandaMir2_SmTiles200,

            ShandaMir2_Objects = 500,
            ShandaMir2_Objects2,
            ShandaMir2_Objects3,
            ShandaMir2_Objects4,
            ShandaMir2_Objects5,
            ShandaMir2_Objects6,
            ShandaMir2_Objects7,
            ShandaMir2_Objects8,
            ShandaMir2_Objects9,
            ShandaMir2_Objects10,
            ShandaMir2_Objects11,
            ShandaMir2_Objects12,
            ShandaMir2_Objects13,
            ShandaMir2_Objects14,
            ShandaMir2_Objects15,
            ShandaMir2_Objects16,
            ShandaMir2_Objects17,
            ShandaMir2_Objects18,
            ShandaMir2_Objects19,
            ShandaMir2_Objects20,
            ShandaMir2_Objects21,
            ShandaMir2_Objects22,
            ShandaMir2_Objects23,
            ShandaMir2_Objects24,
            ShandaMir2_Objects25,
            ShandaMir2_Objects26,
            ShandaMir2_Objects27,
            ShandaMir2_Objects28,
            ShandaMir2_Objects29,
            ShandaMir2_Objects30,
            ShandaMir2_Objects31,
            ShandaMir2_Objects32,
            ShandaMir2_Objects33,
            ShandaMir2_Objects34,
            ShandaMir2_Objects35,
            ShandaMir2_Objects36,
            ShandaMir2_Objects37,
            ShandaMir2_Objects38,
            ShandaMir2_Objects39,
            ShandaMir2_Objects40,
            ShandaMir2_Objects41,
            ShandaMir2_Objects42,
            ShandaMir2_Objects43,
            ShandaMir2_Objects44,
            ShandaMir2_Objects45,
            ShandaMir2_Objects46,
            ShandaMir2_Objects47,
            ShandaMir2_Objects48,
            ShandaMir2_Objects49,
            ShandaMir2_Objects50,
            ShandaMir2_Objects51,
            ShandaMir2_Objects52,
            ShandaMir2_Objects53,
            ShandaMir2_Objects54,
            ShandaMir2_Objects55,
            ShandaMir2_Objects56,
            ShandaMir2_Objects57,
            ShandaMir2_Objects58,
            ShandaMir2_Objects59,
            ShandaMir2_Objects60,
            ShandaMir2_Objects61,
            ShandaMir2_Objects62,
            ShandaMir2_Objects63,
            ShandaMir2_Objects64,
            ShandaMir2_Objects65,
            ShandaMir2_Objects66,
            ShandaMir2_Objects67,
            ShandaMir2_Objects68,
            ShandaMir2_Objects69,
            ShandaMir2_Objects70,
            ShandaMir2_Objects71,
            ShandaMir2_Objects72,
            ShandaMir2_Objects73,
            ShandaMir2_Objects74,
            ShandaMir2_Objects75,
            ShandaMir2_Objects76,
            ShandaMir2_Objects77,
            ShandaMir2_Objects78,
            ShandaMir2_Objects79,
            ShandaMir2_Objects80,
            ShandaMir2_Objects81,
            ShandaMir2_Objects82,
            ShandaMir2_Objects83,
            ShandaMir2_Objects84,
            ShandaMir2_Objects85,
            ShandaMir2_Objects86,
            ShandaMir2_Objects87,
            ShandaMir2_Objects88,
            ShandaMir2_Objects89,
            ShandaMir2_Objects90,
            ShandaMir2_Objects91,
            ShandaMir2_Objects92,
            ShandaMir2_Objects93,
            ShandaMir2_Objects94,
            ShandaMir2_Objects95,
            ShandaMir2_Objects96,
            ShandaMir2_Objects97,
            ShandaMir2_Objects98,
            ShandaMir2_Objects99,
            ShandaMir2_Objects100,
            ShandaMir2_Objects101,
            ShandaMir2_Objects102,
            ShandaMir2_Objects103,
            ShandaMir2_Objects104,
            ShandaMir2_Objects105,
            ShandaMir2_Objects106,
            ShandaMir2_Objects107,
            ShandaMir2_Objects108,
            ShandaMir2_Objects109,
            ShandaMir2_Objects110,
            ShandaMir2_Objects111,
            ShandaMir2_Objects112,
            ShandaMir2_Objects113,
            ShandaMir2_Objects114,
            ShandaMir2_Objects115,
            ShandaMir2_Objects116,
            ShandaMir2_Objects117,
            ShandaMir2_Objects118,
            ShandaMir2_Objects119,
            ShandaMir2_Objects120,
            ShandaMir2_Objects121,
            ShandaMir2_Objects122,
            ShandaMir2_Objects123,
            ShandaMir2_Objects124,
            ShandaMir2_Objects125,
            ShandaMir2_Objects126,
            ShandaMir2_Objects127,
            ShandaMir2_Objects128,
            ShandaMir2_Objects129,
            ShandaMir2_Objects130,
            ShandaMir2_Objects131,
            ShandaMir2_Objects132,
            ShandaMir2_Objects133,
            ShandaMir2_Objects134,
            ShandaMir2_Objects135,
            ShandaMir2_Objects136,
            ShandaMir2_Objects137,
            ShandaMir2_Objects138,
            ShandaMir2_Objects139,
            ShandaMir2_Objects140,
            ShandaMir2_Objects141,
            ShandaMir2_Objects142,
            ShandaMir2_Objects143,
            ShandaMir2_Objects144,
            ShandaMir2_Objects145,
            ShandaMir2_Objects146,
            ShandaMir2_Objects147,
            ShandaMir2_Objects148,
            ShandaMir2_Objects149,
            ShandaMir2_Objects150,
            ShandaMir2_Objects151,
            ShandaMir2_Objects152,
            ShandaMir2_Objects153,
            ShandaMir2_Objects154,
            ShandaMir2_Objects155,
            ShandaMir2_Objects156,
            ShandaMir2_Objects157,
            ShandaMir2_Objects158,
            ShandaMir2_Objects159,
            ShandaMir2_Objects160,
            ShandaMir2_Objects161,
            ShandaMir2_Objects162,
            ShandaMir2_Objects163,
            ShandaMir2_Objects164,
            ShandaMir2_Objects165,
            ShandaMir2_Objects166,
            ShandaMir2_Objects167,
            ShandaMir2_Objects168,
            ShandaMir2_Objects169,
            ShandaMir2_Objects170,
            ShandaMir2_Objects171,
            ShandaMir2_Objects172,
            ShandaMir2_Objects173,
            ShandaMir2_Objects174,
            ShandaMir2_Objects175,
            ShandaMir2_Objects176,
            ShandaMir2_Objects177,
            ShandaMir2_Objects178,
            ShandaMir2_Objects179,
            ShandaMir2_Objects180,
            ShandaMir2_Objects181,
            ShandaMir2_Objects182,
            ShandaMir2_Objects183,
            ShandaMir2_Objects184,
            ShandaMir2_Objects185,
            ShandaMir2_Objects186,
            ShandaMir2_Objects187,
            ShandaMir2_Objects188,
            ShandaMir2_Objects189,
            ShandaMir2_Objects190,
            ShandaMir2_Objects191,
            ShandaMir2_Objects192,
            ShandaMir2_Objects193,
            ShandaMir2_Objects194,
            ShandaMir2_Objects195,
            ShandaMir2_Objects196,
            ShandaMir2_Objects197,
            ShandaMir2_Objects198,
            ShandaMir2_Objects199,
            ShandaMir2_Objects200,
        }

        private MapReader mapFile;
        OpenFileDialog OFD = new OpenFileDialog();
        public List<FileEntry> Entries = new List<FileEntry>();
        public List<Control> NewControls = new List<Control>();

        public TfmMain()
        {
            InitializeComponent();            
        }

        private void btnSelectMap_Click(object sender, EventArgs e)
        {
            OFD.ShowDialog();

            if (OFD.FileName == null)
                return;
            else
            {
                LoadMap(OFD.FileName);
            }
        }

        private void LoadMap(string fname)
        {
            lbMap.Text = string.Format("Map {0}", fname);
            try
            {
                mapFile = new MapReader(fname);
                Entries.Clear();

                for (int i = 0; i < NewControls.Count; i++)
                {
                    Control control = NewControls[i];
                    control.Dispose();
                }
                NewControls.Clear();

                for (int x = 0; x < mapFile.Width; x++)
                {
                    for (int y = 0; y < mapFile.Height; y++)
                    {
                        FileEntry entry = Entries.FirstOrDefault(m => m.OldIndex == mapFile.MapCells[x, y].BackIndex);
                        if (entry == null)
                        {
                            Entries.Add(new FileEntry()
                            {
                                fileType = FileType.Back,
                                OldIndex = mapFile.MapCells[x, y].BackIndex,
                                NewIndex = mapFile.MapCells[x, y].BackIndex,
                                Offset = 0,
                                NewImage = 0
                            });
                        }

                        entry = Entries.FirstOrDefault(m => m.OldIndex == mapFile.MapCells[x, y].MiddleIndex);
                        if (entry == null)
                        {
                            Entries.Add(new FileEntry()
                            {
                                fileType = FileType.Middle,
                                OldIndex = mapFile.MapCells[x, y].MiddleIndex,
                                NewIndex = mapFile.MapCells[x, y].MiddleIndex,
                                Offset = 0,
                                NewImage = 0
                            });
                        }

                        entry = Entries.FirstOrDefault(m => m.OldIndex == mapFile.MapCells[x, y].FrontIndex);
                        if (entry == null)
                        {
                            Entries.Add(new FileEntry()
                            {
                                fileType = FileType.Front,
                                OldIndex = mapFile.MapCells[x, y].FrontIndex,
                                NewIndex = mapFile.MapCells[x, y].FrontIndex,
                                Offset = 0,
                                NewImage = 0
                            });
                        }
                    }
                }

                int yy = 10;
                foreach (FileEntry entry in Entries)
                {
                    Label namelabel = new Label();
                    namelabel.Location = new Point(13, yy);
                    namelabel.Text = Enum.GetName(typeof(FileType), entry.fileType);
                    namelabel.AutoSize = true;
                    panel1.Controls.Add(namelabel);
                    NewControls.Add(namelabel);

                    Label oldlabel = new Label();
                    oldlabel.Location = new Point(63, yy);
                    oldlabel.Text = Enum.GetName(typeof(FileNames), (FileNames)entry.OldIndex);
                    oldlabel.AutoSize = true;
                    oldlabel.BackColor = Color.LightGray;
                    panel1.Controls.Add(oldlabel);
                    NewControls.Add(oldlabel);

                    Label label = new Label();
                    label.Location = new Point(203, yy);
                    label.Text = "Change to:";
                    label.AutoSize = true;
                    panel1.Controls.Add(label);
                    NewControls.Add(label);

                    ComboBox cbox = new ComboBox();
                    cbox.DropDownStyle = ComboBoxStyle.DropDownList;
                    cbox.Location = new Point(303, yy);
                    cbox.Width = 150;
                    cbox.Items.AddRange(Enum.GetValues(typeof(FileNames)).Cast<object>().ToArray());
                    panel1.Controls.Add(cbox);
                    NewControls.Add(cbox);
                    cbox.SelectedItem = null;
                    cbox.SelectedItem = (FileNames)entry.OldIndex;

                    cbox.SelectedIndexChanged += (oo, ee) =>
                    {
                        entry.NewIndex = (int)((FileNames)cbox.SelectedItem);
                    };

                    Label slabel = new Label();
                    slabel.Location = new Point(463, yy);
                    slabel.Text = "Image Offset:";
                    slabel.AutoSize = true;
                    panel1.Controls.Add(slabel);
                    NewControls.Add(slabel);

                    NumericUpDown nud = new NumericUpDown();
                    nud.Location = new Point(543, yy - 2);
                    nud.DecimalPlaces = 0;
                    nud.Minimum = short.MinValue;
                    nud.Maximum = short.MaxValue;
                    nud.Increment = 1;
                    nud.Value = entry.Offset;

                    nud.ValueChanged += (oo, ee) =>
                    {
                        entry.Offset = (int)nud.Value;
                    };

                    panel1.Controls.Add(nud);
                    NewControls.Add(nud);

                    yy += 25;
                }
            }
            catch (Exception)
            {
            }
        }



        private void btnProcess_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < mapFile.Width; x++)
            {
                for (int y = 0; y < mapFile.Height; y++)
                {
                    FileEntry entry = Entries.FirstOrDefault(m => m.OldIndex == mapFile.MapCells[x, y].BackIndex);
                    if (entry != null)
                    {
                        mapFile.MapCells[x, y].BackIndex = (short)entry.NewIndex;
                        mapFile.MapCells[x, y].BackImage += entry.Offset;
                    }

                    entry = Entries.FirstOrDefault(m => m.OldIndex == mapFile.MapCells[x, y].MiddleIndex);
                    if (entry != null)
                    {
                        mapFile.MapCells[x, y].MiddleIndex = (short)entry.NewIndex;
                        mapFile.MapCells[x, y].MiddleImage += entry.Offset;
                    }

                    entry = Entries.FirstOrDefault(m => m.OldIndex == mapFile.MapCells[x, y].FrontIndex);
                    if (entry != null)
                    {
                        mapFile.MapCells[x, y].FrontIndex = (short)entry.NewIndex;
                        mapFile.MapCells[x, y].FrontImage += entry.Offset;
                    }
                }
            }
            mapFile.Save(OFD.FileName);
            MessageBox.Show("done");
            LoadMap(OFD.FileName);
        }
    }
}