using System;
using System.Reflection;
using System.CodeDom.Compiler;
using Microsoft.CSharp;  
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;                      //For : OpenFileDialog / SaveFileDialog
using System.Windows.Ink;                   //For : InkCanvas
using System.Windows.Markup;                //For : XamlWriter
using System.Windows.Input.StylusPlugIns;   //For : DrawingAttributes
namespace ExpressionParser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Parameters

        //Lists to save symbol templates
        private List<Multistroke> multistrokes = new List<Multistroke>();
        //Counters to count how how many times sympoles saved as templates
        public int count0 = 0, count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0;
        public int count6 = 0, count7 = 0, count8 = 0, count9 = 0, count10 = 0, count11 = 0;
        public int count12 = 0, count13 = 0, count14 = 0;

        #endregion

        public MainWindow()
        {
            InitializeComponent();
            //By Default
            Notes.EditingMode = InkCanvasEditingMode.Ink;
            //Creat 1 template for each symbol
            bool useBoundedRotationInvariance = true;
            String name;
            List<List<Point>> strokes = new List<List<Point>>();
            List<Point> temPoints = new List<Point>();
            #region 0
            Multistroke multistroke;
            name="0";
            temPoints.Add(new Point(456.989966555184,147.060532687651));
            temPoints.Add(new Point(460.395256916996,146.188861985472));
            temPoints.Add(new Point(463.946488294314,145.414043583535));
            temPoints.Add(new Point(467.59501368197,144.542372881356));
            temPoints.Add(new Point(471.584068105807,143.864406779661));
            temPoints.Add(new Point(476.010945576163,143.525423728814));
            temPoints.Add(new Point(480.681058072362,143.525423728814));
            temPoints.Add(new Point(485.351170568562,143.719128329298));
            temPoints.Add(new Point(490.06993006993,144.203389830508));
            temPoints.Add(new Point(494.788689571298,144.832929782082));
            temPoints.Add(new Point(499.604743083004,145.607748184019));
            temPoints.Add(new Point(504.274855579203,146.576271186441));
            temPoints.Add(new Point(508.847674065065,147.738498789346));
            temPoints.Add(new Point(513.225904530252,149.046004842615));
            temPoints.Add(new Point(517.458193979933,150.740920096852));
            temPoints.Add(new Point(521.301307388264,152.726392251816));
            temPoints.Add(new Point(524.901185770751,155.050847457627));
            temPoints.Add(new Point(528.014594101551,157.665859564165));
            temPoints.Add(new Point(530.787473396169,160.716707021792));
            temPoints.Add(new Point(533.0738826391,164.058111380145));
            temPoints.Add(new Point(535.068409851018,167.738498789346));
            temPoints.Add(new Point(536.57646701125,171.806295399516));
            temPoints.Add(new Point(537.841289145637,176.261501210654));
            temPoints.Add(new Point(538.765582243843,180.910411622276));
            temPoints.Add(new Point(539.446640316206,185.607748184019));
            temPoints.Add(new Point(539.884463362724,190.595641646489));
            temPoints.Add(new Point(539.981757373062,195.583535108959));
            temPoints.Add(new Point(539.933110367893,200.716707021792));
            temPoints.Add(new Point(539.689875342049,205.946731234867));
            temPoints.Add(new Point(539.300699300699,211.176755447942));
            temPoints.Add(new Point(538.668288233506,216.164648910412));
            temPoints.Add(new Point(537.938583155974,221.152542372881));
            temPoints.Add(new Point(536.965643052599,226.140435835351));
            temPoints.Add(new Point(535.79811492855,230.983050847458));
            temPoints.Add(new Point(534.581939799331,235.922518159806));
            temPoints.Add(new Point(532.976588628763,240.813559322034));
            temPoints.Add(new Point(531.273943447856,245.65617433414));
            temPoints.Add(new Point(529.376710246275,250.305084745763));
            temPoints.Add(new Point(527.187595013682,254.953995157385));
            temPoints.Add(new Point(524.657950744907,259.409200968523));
            temPoints.Add(new Point(521.885071450289,263.864406779661));
            temPoints.Add(new Point(518.72301611432,268.077481840194));
            temPoints.Add(new Point(515.366372757677,272.096852300242));
            temPoints.Add(new Point(511.76649437519,275.825665859564));
            temPoints.Add(new Point(507.923380966859,279.26392251816));
            temPoints.Add(new Point(503.885679537853,282.411622276029));
            temPoints.Add(new Point(499.75068409851,285.220338983051));
            temPoints.Add(new Point(495.469747643661,287.690072639225));
            temPoints.Add(new Point(491.140164183642,289.772397094431));
            temPoints.Add(new Point(486.761933718455,291.467312348668));
            temPoints.Add(new Point(482.383703253268,292.823244552058));
            temPoints.Add(new Point(478.005472788081,293.694915254237));
            temPoints.Add(new Point(473.773183338401,294.27602905569));
            temPoints.Add(new Point(469.638187899057,294.518159806295));
            temPoints.Add(new Point(465.64913347522,294.421307506053));
            temPoints.Add(new Point(461.757373061721,294.082324455206));
            temPoints.Add(new Point(458.060200668896,293.501210653753));
            temPoints.Add(new Point(454.557616296747,292.629539951574));
            temPoints.Add(new Point(451.298266950441,291.515738498789));
            temPoints.Add(new Point(448.330799635147,290.062953995157));
            temPoints.Add(new Point(445.50927333536,288.319612590799));
            temPoints.Add(new Point(442.979629066586,286.334140435835));
            temPoints.Add(new Point(440.693219823655,284.154963680387));
            temPoints.Add(new Point(438.601398601399,281.733656174334));
            temPoints.Add(new Point(436.850106415324,279.070217917676));
            temPoints.Add(new Point(435.244755244755,276.213075060533));
            temPoints.Add(new Point(433.88263910003,273.210653753027));
            temPoints.Add(new Point(432.666463970812,270.014527845036));
            temPoints.Add(new Point(431.596229857099,266.673123486683));
            temPoints.Add(new Point(430.623289753725,263.138014527845));
            temPoints.Add(new Point(429.747643660687,259.409200968523));
            temPoints.Add(new Point(429.066585588325,255.63196125908));
            temPoints.Add(new Point(428.434174521131,251.757869249395));
            temPoints.Add(new Point(427.947704469444,247.883777239709));
            temPoints.Add(new Point(427.461234417756,244.009685230024));
            temPoints.Add(new Point(427.072058376406,240.18401937046));
            temPoints.Add(new Point(426.682882335056,236.358353510896));
            temPoints.Add(new Point(426.391000304044,232.581113801453));
            temPoints.Add(new Point(426.1477652782,228.80387409201));
            temPoints.Add(new Point(425.807236242019,225.075060532688));
            temPoints.Add(new Point(425.612648221344,221.443099273608));
            temPoints.Add(new Point(425.3694131955,217.956416464891));
            temPoints.Add(new Point(425.174825174825,214.372881355932));
            temPoints.Add(new Point(424.98023715415,210.886198547215));
            temPoints.Add(new Point(424.882943143813,207.544794188862));
            temPoints.Add(new Point(424.785649133475,204.348668280872));
            temPoints.Add(new Point(424.737002128306,201.200968523002));
            temPoints.Add(new Point(424.882943143813,197.956416464891));
            temPoints.Add(new Point(425.174825174825,194.663438256659));
            temPoints.Add(new Point(425.515354211006,191.370460048426));
            temPoints.Add(new Point(426.050471267863,188.222760290557));
            temPoints.Add(new Point(426.634235329887,185.075060532688));
            temPoints.Add(new Point(427.31529340225,181.830508474576));
            temPoints.Add(new Point(428.190939495287,178.779661016949));
            temPoints.Add(new Point(429.212526603831,175.825665859564));
            temPoints.Add(new Point(430.282760717543,173.016949152542));
            temPoints.Add(new Point(431.450288841593,170.353510895884));
            temPoints.Add(new Point(432.812404986318,167.690072639225));
            temPoints.Add(new Point(434.27181514138,165.075060532688));
            temPoints.Add(new Point(435.925813317118,162.508474576271));
            temPoints.Add(new Point(437.823046518699,160.038740920097));
            temPoints.Add(new Point(439.817573730617,157.617433414044));
            temPoints.Add(new Point(442.006688963211,155.292978208232));
            temPoints.Add(new Point(444.293098206142,153.113801452784));
            temPoints.Add(new Point(446.725448464579,151.031476997579));
            temPoints.Add(new Point(449.206445728185,149.191283292978));
            temPoints.Add(new Point(451.73608999696,147.544794188862));
            temPoints.Add(new Point(454.314381270903,146.09200968523));
            temPoints.Add(new Point(456.795378534509,144.73607748184));
            temPoints.Add(new Point(459.179081787777,143.525423728814));
            temPoints.Add(new Point(461.270903010033,142.508474576271));
            temPoints.Add(new Point(463.265430221952,141.588377723971));
            temPoints.Add(new Point(465.016722408027,140.765133171913));
            temPoints.Add(new Point(466.622073578595,140.087167070218));
            temPoints.Add(new Point(467.98418972332,139.457627118644));
            temPoints.Add(new Point(469.297658862876,139.021791767554));
            temPoints.Add(new Point(470.416539981757,138.634382566586));
            temPoints.Add(new Point(471.778656126482,138.682808716707));
            temPoints.Add(new Point(472.65430221952,138.392251815981));
            temPoints.Add(new Point(474.113712374582,138.779661016949));
            temPoints.Add(new Point(475.329887503801,139.118644067797));
            temPoints.Add(new Point(476.789297658863,139.74818401937));
            strokes.Add(temPoints);
            count0++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            name="0";
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(443.95256916996,142.217917675545));
            temPoints.Add(new Point(445.022803283673,141.927360774818));
            temPoints.Add(new Point(445.849802371542,141.200968523002));
            temPoints.Add(new Point(447.211918516266,140.668280871671));
            temPoints.Add(new Point(448.62268166616,140.135593220339));
            temPoints.Add(new Point(450.17938583156,139.554479418886));
            temPoints.Add(new Point(452.173913043478,139.312348668281));
            temPoints.Add(new Point(454.022499239891,138.731234866828));
            temPoints.Add(new Point(456.454849498328,138.634382566586));
            temPoints.Add(new Point(458.595317725752,138.198547215496));
            temPoints.Add(new Point(461.465491030708,138.246973365617));
            temPoints.Add(new Point(464.238370325327,138.101694915254));
            temPoints.Add(new Point(467.789601702645,138.295399515738));
            temPoints.Add(new Point(471.389480085132,138.392251815981));
            temPoints.Add(new Point(475.524475524476,138.779661016949));
            temPoints.Add(new Point(479.708117968987,139.312348668281));
            temPoints.Add(new Point(484.232289449681,140.087167070218));
            temPoints.Add(new Point(488.90240194588,140.958837772397));
            temPoints.Add(new Point(493.767102462755,142.121065375303));
            temPoints.Add(new Point(498.631802979629,143.476997578692));
            temPoints.Add(new Point(503.496503496503,145.220338983051));
            temPoints.Add(new Point(508.26391000304,147.205811138015));
            temPoints.Add(new Point(513.079963514746,149.675544794189));
            temPoints.Add(new Point(517.701429005777,152.290556900726));
            temPoints.Add(new Point(522.322894496808,155.19612590799));
            temPoints.Add(new Point(526.701124961995,158.34382566586));
            temPoints.Add(new Point(530.982061416844,161.830508474576));
            temPoints.Add(new Point(534.922468835512,165.414043583535));
            temPoints.Add(new Point(538.668288233506,169.142857142857));
            temPoints.Add(new Point(542.073578595318,173.016949152542));
            temPoints.Add(new Point(545.284280936455,177.036319612591));
            temPoints.Add(new Point(548.203101246579,181.200968523002));
            temPoints.Add(new Point(550.781392520523,185.414043583535));
            temPoints.Add(new Point(553.019154758285,189.820823244552));
            temPoints.Add(new Point(554.916387959866,194.227602905569));
            temPoints.Add(new Point(556.424445120097,198.779661016949));
            temPoints.Add(new Point(557.640620249316,203.525423728814));
            temPoints.Add(new Point(558.467619337184,208.464891041162));
            temPoints.Add(new Point(558.905442383703,213.452784503632));
            temPoints.Add(new Point(558.954089388872,218.392251815981));
            temPoints.Add(new Point(558.710854363028,223.525423728814));
            temPoints.Add(new Point(558.029796290666,228.610169491525));
            temPoints.Add(new Point(557.056856187291,233.8401937046));
            temPoints.Add(new Point(555.694740042566,239.167070217918));
            temPoints.Add(new Point(553.99209486166,244.348668280872));
            temPoints.Add(new Point(551.900273639404,249.336561743341));
            temPoints.Add(new Point(549.419276375798,254.324455205811));
            temPoints.Add(new Point(546.549103070842,259.118644067797));
            temPoints.Add(new Point(543.338400729705,263.912832929782));
            temPoints.Add(new Point(539.884463362724,268.464891041162));
            temPoints.Add(new Point(536.041349954393,272.968523002421));
            temPoints.Add(new Point(531.90635451505,277.133171912833));
            temPoints.Add(new Point(527.576771055032,281.10411622276));
            temPoints.Add(new Point(523.052599574339,284.881355932203));
            temPoints.Add(new Point(518.285193067802,288.36803874092));
            temPoints.Add(new Point(513.469139556096,291.661016949153));
            temPoints.Add(new Point(508.409851018547,294.663438256659));
            temPoints.Add(new Point(503.058680449985,297.423728813559));
            temPoints.Add(new Point(497.610215871085,299.893462469734));
            temPoints.Add(new Point(491.967163271511,302.121065375303));
            temPoints.Add(new Point(486.275463666768,304.106537530266));
            temPoints.Add(new Point(480.486470051687,305.898305084746));
            temPoints.Add(new Point(474.648829431438,307.44794188862));
            temPoints.Add(new Point(468.665247795683,308.707021791768));
            temPoints.Add(new Point(462.827607175433,309.772397094431));
            temPoints.Add(new Point(457.087260565521,310.595641646489));
            temPoints.Add(new Point(451.541501976285,311.176755447942));
            temPoints.Add(new Point(446.190331407723,311.612590799031));
            temPoints.Add(new Point(440.936454849498,311.854721549637));
            temPoints.Add(new Point(435.877166311949,311.903147699758));
            temPoints.Add(new Point(430.915171784737,311.806295399516));
            temPoints.Add(new Point(426.293706293706,311.661016949153));
            temPoints.Add(new Point(421.818181818182,311.322033898305));
            temPoints.Add(new Point(417.585892368501,310.789346246973));
            temPoints.Add(new Point(413.596837944664,310.062953995157));
            temPoints.Add(new Point(409.753724536333,309.142857142857));
            temPoints.Add(new Point(406.105199148677,307.980629539952));
            temPoints.Add(new Point(402.699908786865,306.673123486683));
            temPoints.Add(new Point(399.537853450897,305.17191283293));
            temPoints.Add(new Point(396.424445120097,303.476997578692));
            temPoints.Add(new Point(393.505624809973,301.53995157385));
            temPoints.Add(new Point(390.684098510185,299.506053268765));
            temPoints.Add(new Point(388.057160231073,297.326876513317));
            temPoints.Add(new Point(385.576162967467,295.002421307506));
            temPoints.Add(new Point(383.338400729705,292.532687651332));
            temPoints.Add(new Point(381.343873517787,289.917675544794));
            temPoints.Add(new Point(379.543934326543,287.205811138015));
            temPoints.Add(new Point(377.987230161143,284.300242130751));
            temPoints.Add(new Point(376.57646701125,281.394673123487));
            temPoints.Add(new Point(375.360291882031,278.440677966102));
            temPoints.Add(new Point(374.290057768319,275.341404358353));
            temPoints.Add(new Point(373.317117664944,272.242130750605));
            temPoints.Add(new Point(372.392824566738,269.094430992736));
            temPoints.Add(new Point(371.5171784737,265.898305084746));
            temPoints.Add(new Point(370.787473396169,262.653753026634));
            temPoints.Add(new Point(370.057768318638,259.457627118644));
            temPoints.Add(new Point(369.474004256613,256.213075060533));
            temPoints.Add(new Point(368.987534204926,252.968523002421));
            temPoints.Add(new Point(368.598358163576,249.869249394673));
            temPoints.Add(new Point(368.403770142901,246.721549636804));
            temPoints.Add(new Point(368.306476132563,243.670702179177));
            temPoints.Add(new Point(368.355123137732,240.668280871671));
            temPoints.Add(new Point(368.549711158407,237.859564164649));
            temPoints.Add(new Point(368.792946184251,235.002421307506));
            temPoints.Add(new Point(369.230769230769,232.145278450363));
            temPoints.Add(new Point(369.668592277288,229.191283292978));
            temPoints.Add(new Point(370.252356339313,226.188861985472));
            temPoints.Add(new Point(370.982061416844,223.283292978208));
            temPoints.Add(new Point(371.711766494375,220.377723970944));
            temPoints.Add(new Point(372.538765582244,217.520581113801));
            temPoints.Add(new Point(373.414411675281,214.663438256659));
            temPoints.Add(new Point(374.484645788994,211.806295399516));
            temPoints.Add(new Point(375.506232897537,209.094430992736));
            temPoints.Add(new Point(376.673761021587,206.479418886199));
            temPoints.Add(new Point(377.889936150806,203.912832929782));
            temPoints.Add(new Point(379.154758285193,201.297820823245));
            temPoints.Add(new Point(380.516874429918,198.585956416465));
            temPoints.Add(new Point(381.97628458498,195.728813559322));
            temPoints.Add(new Point(383.53298875038,192.823244552058));
            temPoints.Add(new Point(385.138339920949,189.966101694915));
            temPoints.Add(new Point(386.840985101855,187.060532687651));
            temPoints.Add(new Point(388.689571298267,184.203389830508));
            temPoints.Add(new Point(390.586804499848,181.297820823245));
            temPoints.Add(new Point(392.581331711767,178.537530266344));
            temPoints.Add(new Point(394.721799939191,175.922518159806));
            temPoints.Add(new Point(397.008209182122,173.452784503632));
            temPoints.Add(new Point(399.343265430222,171.0799031477));
            temPoints.Add(new Point(401.824262693828,168.707021791768));
            temPoints.Add(new Point(404.45120097294,166.382566585956));
            temPoints.Add(new Point(407.224080267559,164.009685230024));
            temPoints.Add(new Point(410.142900577683,161.782082324455));
            temPoints.Add(new Point(413.207661903314,159.554479418886));
            temPoints.Add(new Point(416.321070234114,157.326876513317));
            temPoints.Add(new Point(419.434478564913,155.19612590799));
            temPoints.Add(new Point(422.742474916388,153.162227602906));
            temPoints.Add(new Point(426.050471267863,151.225181598063));
            temPoints.Add(new Point(429.407114624506,149.433414043584));
            temPoints.Add(new Point(432.909698996655,147.835351089588));
            temPoints.Add(new Point(436.412283368805,146.285714285714));
            temPoints.Add(new Point(439.963514746123,144.881355932203));
            temPoints.Add(new Point(443.56339312861,143.573849878935));
            temPoints.Add(new Point(447.211918516266,142.411622276029));
            temPoints.Add(new Point(450.763149893585,141.394673123487));
            temPoints.Add(new Point(454.265734265734,140.571428571429));
            temPoints.Add(new Point(457.573730617209,139.796610169492));
            temPoints.Add(new Point(460.589844937671,139.215496368039));
            temPoints.Add(new Point(463.314077227121,138.634382566586));
            temPoints.Add(new Point(465.795074490727,138.34382566586));
            temPoints.Add(new Point(467.546366676801,137.665859564165));
            temPoints.Add(new Point(469.297658862876,137.375302663438));
            temPoints.Add(new Point(470.367892976589,136.697336561743));
            temPoints.Add(new Point(471.340833079963,136.019370460048));
            temPoints.Add(new Point(471.827303131651,134.953995157385));
            strokes.Add(temPoints);
            count0++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            #endregion
            #region 1
            strokes.Clear();
            temPoints.Clear();
            name = "1";
            temPoints.Add(new Point(391.754332623898, 139.457627118644));
            temPoints.Add(new Point(391.705685618729, 138.876513317191));
            temPoints.Add(new Point(391.705685618729, 138.876513317191));
            temPoints.Add(new Point(391.705685618729, 138.876513317191));
            temPoints.Add(new Point(391.511097598054, 138.295399515738));
            temPoints.Add(new Point(391.511097598054, 138.295399515738));
            temPoints.Add(new Point(391.511097598054, 138.295399515738));
            temPoints.Add(new Point(391.511097598054, 138.295399515738));
            temPoints.Add(new Point(391.511097598054, 138.295399515738));
            temPoints.Add(new Point(391.511097598054, 138.295399515738));
            temPoints.Add(new Point(391.511097598054, 138.295399515738));
            temPoints.Add(new Point(391.511097598054, 138.779661016949));
            temPoints.Add(new Point(391.511097598054, 138.779661016949));
            temPoints.Add(new Point(391.802979629067, 139.893462469734));
            temPoints.Add(new Point(391.948920644573, 140.571428571429));
            temPoints.Add(new Point(392.386743691092, 141.733656174334));
            temPoints.Add(new Point(392.678625722104, 142.799031476998));
            temPoints.Add(new Point(393.21374277896, 144.300242130751));
            temPoints.Add(new Point(393.651565825479, 145.753026634383));
            temPoints.Add(new Point(394.283976892673, 147.544794188862));
            temPoints.Add(new Point(394.819093949529, 149.481840193705));
            temPoints.Add(new Point(395.451505016722, 151.709443099274));
            temPoints.Add(new Point(395.986622073579, 154.033898305085));
            temPoints.Add(new Point(396.619033140772, 156.55205811138));
            temPoints.Add(new Point(397.154150197628, 159.118644067797));
            temPoints.Add(new Point(397.737914259653, 161.975786924939));
            temPoints.Add(new Point(398.27303131651, 164.929782082324));
            temPoints.Add(new Point(398.905442383703, 168.125907990315));
            temPoints.Add(new Point(399.391912435391, 171.418886198547));
            temPoints.Add(new Point(400.024323502584, 175.19612590799));
            temPoints.Add(new Point(400.559440559441, 179.118644067797));
            temPoints.Add(new Point(401.289145636972, 183.331719128329));
            temPoints.Add(new Point(401.921556704165, 187.835351089588));
            temPoints.Add(new Point(402.699908786865, 192.484261501211));
            temPoints.Add(new Point(403.429613864396, 197.326876513317));
            temPoints.Add(new Point(404.256612952265, 202.508474576271));
            temPoints.Add(new Point(405.034965034965, 207.738498789346));
            temPoints.Add(new Point(405.910611128002, 213.016949152542));
            temPoints.Add(new Point(406.591669200365, 218.295399515738));
            temPoints.Add(new Point(407.321374277896, 223.719128329298));
            temPoints.Add(new Point(407.95378534509, 228.949152542373));
            temPoints.Add(new Point(408.634843417452, 234.421307506053));
            temPoints.Add(new Point(409.12131346914, 239.893462469734));
            temPoints.Add(new Point(409.656430525996, 245.220338983051));
            temPoints.Add(new Point(410.094253572514, 250.401937046005));
            temPoints.Add(new Point(410.629370629371, 255.63196125908));
            temPoints.Add(new Point(411.115840681058, 260.61985472155));
            temPoints.Add(new Point(411.602310732745, 265.801452784504));
            temPoints.Add(new Point(412.137427789602, 270.886198547215));
            temPoints.Add(new Point(412.672544846458, 275.777239709443));
            temPoints.Add(new Point(413.207661903314, 280.426150121065));
            temPoints.Add(new Point(413.840072970508, 285.026634382567));
            temPoints.Add(new Point(414.423837032533, 289.433414043584));
            temPoints.Add(new Point(415.056248099726, 293.791767554479));
            temPoints.Add(new Point(415.68865916692, 298.053268765133));
            temPoints.Add(new Point(416.272423228945, 302.072639225182));
            temPoints.Add(new Point(416.85618729097, 305.946731234867));
            temPoints.Add(new Point(417.391304347826, 309.72397094431));
            temPoints.Add(new Point(417.975068409851, 313.307506053269));
            temPoints.Add(new Point(418.41289145637, 316.794188861985));
            temPoints.Add(new Point(418.899361508057, 320.135593220339));
            temPoints.Add(new Point(419.337184554576, 323.283292978208));
            temPoints.Add(new Point(419.726360595926, 326.285714285714));
            temPoints.Add(new Point(420.066889632107, 329.142857142857));
            temPoints.Add(new Point(420.310124657951, 331.806295399516));
            temPoints.Add(new Point(420.504712678626, 334.469733656174));
            temPoints.Add(new Point(420.602006688963, 336.939467312349));
            temPoints.Add(new Point(420.602006688963, 339.215496368039));
            temPoints.Add(new Point(420.504712678626, 341.249394673124));
            temPoints.Add(new Point(420.310124657951, 342.944309927361));
            temPoints.Add(new Point(420.164183642444, 344.397094430993));
            temPoints.Add(new Point(419.823654606263, 345.17191283293));
            temPoints.Add(new Point(419.920948616601, 346.09200968523));
            temPoints.Add(new Point(419.920948616601, 346.09200968523));
            temPoints.Add(new Point(419.920948616601, 346.09200968523));
            temPoints.Add(new Point(419.337184554576, 344.73607748184));
            strokes.Add(temPoints);
            count1++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            name = "1";
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(398.27303131651, 157.036319612591));
            temPoints.Add(new Point(398.27303131651, 157.036319612591));
            temPoints.Add(new Point(398.27303131651, 157.036319612591));
            temPoints.Add(new Point(398.27303131651, 157.036319612591));
            temPoints.Add(new Point(398.710854363028, 157.326876513317));
            temPoints.Add(new Point(398.710854363028, 157.326876513317));
            temPoints.Add(new Point(398.710854363028, 157.326876513317));
            temPoints.Add(new Point(399.148677409547, 157.714285714286));
            temPoints.Add(new Point(399.440559440559, 158.198547215496));
            temPoints.Add(new Point(399.440559440559, 158.198547215496));
            temPoints.Add(new Point(399.732441471572, 159.26392251816));
            temPoints.Add(new Point(399.732441471572, 159.893462469734));
            temPoints.Add(new Point(400.024323502584, 160.958837772397));
            temPoints.Add(new Point(400.024323502584, 161.975786924939));
            temPoints.Add(new Point(400.218911523259, 163.428571428571));
            temPoints.Add(new Point(400.170264518091, 164.881355932203));
            temPoints.Add(new Point(400.364852538766, 166.769975786925));
            temPoints.Add(new Point(400.413499543934, 168.610169491525));
            temPoints.Add(new Point(400.705381574947, 170.789346246973));
            temPoints.Add(new Point(400.802675585284, 173.065375302663));
            temPoints.Add(new Point(401.143204621465, 175.825665859564));
            temPoints.Add(new Point(401.435086652478, 178.731234866828));
            temPoints.Add(new Point(401.872909698997, 182.072639225182));
            temPoints.Add(new Point(402.359379750684, 185.365617433414));
            temPoints.Add(new Point(402.89449680754, 189.191283292978));
            temPoints.Add(new Point(403.380966859228, 193.065375302663));
            temPoints.Add(new Point(404.013377926421, 197.375302663438));
            temPoints.Add(new Point(404.597141988446, 201.782082324455));
            temPoints.Add(new Point(405.326847065977, 206.576271186441));
            temPoints.Add(new Point(405.959258133171, 211.467312348668));
            temPoints.Add(new Point(406.737610215871, 216.697336561743));
            temPoints.Add(new Point(407.418668288234, 222.024213075061));
            temPoints.Add(new Point(408.245667376102, 227.544794188862));
            temPoints.Add(new Point(408.926725448465, 233.35593220339));
            temPoints.Add(new Point(409.656430525996, 239.360774818402));
            temPoints.Add(new Point(410.288841593189, 245.317191283293));
            temPoints.Add(new Point(410.921252660383, 251.225181598063));
            temPoints.Add(new Point(411.40772271207, 257.084745762712));
            temPoints.Add(new Point(411.894192763758, 262.992736077482));
            temPoints.Add(new Point(412.18607479477, 268.852300242131));
            temPoints.Add(new Point(412.526603830952, 274.663438256659));
            temPoints.Add(new Point(412.672544846458, 280.087167070218));
            temPoints.Add(new Point(412.867132867133, 285.317191283293));
            temPoints.Add(new Point(412.915779872302, 290.305084745763));
            temPoints.Add(new Point(413.013073882639, 295.19612590799));
            temPoints.Add(new Point(413.013073882639, 299.845036319613));
            temPoints.Add(new Point(413.110367892977, 304.25181598063));
            temPoints.Add(new Point(413.159014898145, 308.36803874092));
            temPoints.Add(new Point(413.207661903314, 312.242130750605));
            temPoints.Add(new Point(413.304955913652, 315.874092009685));
            temPoints.Add(new Point(413.450896929158, 319.312348668281));
            temPoints.Add(new Point(413.596837944664, 322.508474576271));
            temPoints.Add(new Point(413.791425965339, 325.462469733656));
            temPoints.Add(new Point(414.034660991183, 328.174334140436));
            temPoints.Add(new Point(414.277896017026, 330.692493946731));
            temPoints.Add(new Point(414.52113104287, 333.016949152542));
            temPoints.Add(new Point(414.813013073883, 335.292978208232));
            temPoints.Add(new Point(415.104895104895, 337.375302663438));
            temPoints.Add(new Point(415.348130130739, 339.26392251816));
            temPoints.Add(new Point(415.591365156583, 341.007263922518));
            temPoints.Add(new Point(415.737306172089, 342.314769975787));
            temPoints.Add(new Point(416.126482213439, 343.767554479419));
            temPoints.Add(new Point(416.07783520827, 344.348668280872));
            temPoints.Add(new Point(416.07783520827, 344.348668280872));
            temPoints.Add(new Point(415.980541197933, 343.767554479419));
            temPoints.Add(new Point(415.980541197933, 342.266343825666));
            strokes.Add(temPoints);
            count1++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
           
            #endregion
            #region 2

            name = "2";
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(362.61477652782, 187.980629539952));
            temPoints.Add(new Point(362.420188507145, 187.399515738499));
            temPoints.Add(new Point(362.079659470964, 186.769975786925));
            temPoints.Add(new Point(361.933718455458, 186.285714285714));
            temPoints.Add(new Point(361.44724840377, 185.462469733656));
            temPoints.Add(new Point(361.398601398601, 184.978208232446));
            temPoints.Add(new Point(361.009425357251, 184.106537530266));
            temPoints.Add(new Point(360.912131346914, 183.476997578692));
            temPoints.Add(new Point(360.66889632107, 182.411622276029));
            temPoints.Add(new Point(360.66889632107, 181.636803874092));
            temPoints.Add(new Point(360.522955305564, 180.377723970944));
            temPoints.Add(new Point(360.66889632107, 179.312348668281));
            temPoints.Add(new Point(360.717543326239, 177.859564164649));
            temPoints.Add(new Point(361.009425357251, 176.55205811138));
            temPoints.Add(new Point(361.204013377926, 174.857142857143));
            temPoints.Add(new Point(361.739130434783, 173.210653753027));
            temPoints.Add(new Point(362.322894496808, 171.370460048426));
            temPoints.Add(new Point(363.198540589845, 169.530266343826));
            temPoints.Add(new Point(364.122833688051, 167.544794188862));
            temPoints.Add(new Point(365.290361812101, 165.559322033898));
            temPoints.Add(new Point(366.701124961994, 163.428571428571));
            temPoints.Add(new Point(368.403770142901, 161.200968523002));
            temPoints.Add(new Point(370.203709334144, 159.070217917676));
            temPoints.Add(new Point(372.246883551231, 156.891041162228));
            temPoints.Add(new Point(374.435998783825, 154.71186440678));
            temPoints.Add(new Point(376.819702037093, 152.629539951574));
            temPoints.Add(new Point(379.397993311037, 150.64406779661));
            temPoints.Add(new Point(382.122225600486, 148.852300242131));
            temPoints.Add(new Point(384.943751900274, 147.157384987893));
            temPoints.Add(new Point(387.862572210398, 145.753026634383));
            temPoints.Add(new Point(390.87868653086, 144.397094430993));
            temPoints.Add(new Point(393.894800851323, 143.38014527845));
            temPoints.Add(new Point(396.959562176953, 142.46004842615));
            temPoints.Add(new Point(400.121617512922, 141.830508474576));
            temPoints.Add(new Point(403.235025843721, 141.297820823245));
            temPoints.Add(new Point(406.445728184859, 141.055690072639));
            temPoints.Add(new Point(409.656430525996, 140.910411622276));
            temPoints.Add(new Point(412.915779872302, 141.055690072639));
            temPoints.Add(new Point(416.175129218607, 141.346246973366));
            temPoints.Add(new Point(419.531772575251, 141.830508474576));
            temPoints.Add(new Point(422.693827911219, 142.46004842615));
            temPoints.Add(new Point(425.855883247188, 143.331719128329));
            temPoints.Add(new Point(428.87199756765, 144.300242130751));
            temPoints.Add(new Point(431.693523867437, 145.510895883777));
            temPoints.Add(new Point(434.320462146549, 146.818401937046));
            temPoints.Add(new Point(436.752812404986, 148.36803874092));
            temPoints.Add(new Point(438.893280632411, 150.111380145278));
            temPoints.Add(new Point(440.88780784433, 152.096852300242));
            temPoints.Add(new Point(442.639100030404, 154.227602905569));
            temPoints.Add(new Point(444.098510185467, 156.455205811138));
            temPoints.Add(new Point(445.314685314685, 158.82808716707));
            temPoints.Add(new Point(446.190331407723, 161.346246973366));
            temPoints.Add(new Point(446.774095469748, 164.009685230024));
            temPoints.Add(new Point(447.017330495591, 166.673123486683));
            temPoints.Add(new Point(446.871389480085, 169.28813559322));
            temPoints.Add(new Point(446.384919428398, 172));
            temPoints.Add(new Point(445.606567345698, 174.760290556901));
            temPoints.Add(new Point(444.536333231985, 177.665859564165));
            temPoints.Add(new Point(443.222864092429, 180.61985472155));
            temPoints.Add(new Point(441.617512921861, 183.476997578692));
            temPoints.Add(new Point(439.866220735786, 186.334140435835));
            temPoints.Add(new Point(437.920340529036, 189.191283292978));
            temPoints.Add(new Point(435.82851930678, 192.048426150121));
            temPoints.Add(new Point(433.590757069018, 195.002421307506));
            temPoints.Add(new Point(431.158406810581, 197.859564164649));
            temPoints.Add(new Point(428.531468531469, 200.61985472155));
            temPoints.Add(new Point(425.709942231681, 203.38014527845));
            temPoints.Add(new Point(422.888415931894, 206.188861985472));
            temPoints.Add(new Point(419.872301611432, 209.046004842615));
            temPoints.Add(new Point(416.710246275464, 212.048426150121));
            temPoints.Add(new Point(413.450896929158, 215.099273607748));
            temPoints.Add(new Point(410.094253572514, 218.053268765133));
            temPoints.Add(new Point(406.543022195196, 221.10411622276));
            temPoints.Add(new Point(402.89449680754, 224.203389830508));
            temPoints.Add(new Point(399.100030404378, 227.302663438257));
            temPoints.Add(new Point(395.256916996047, 230.450363196126));
            temPoints.Add(new Point(391.316509577379, 233.549636803874));
            temPoints.Add(new Point(387.42474916388, 236.697336561743));
            temPoints.Add(new Point(383.53298875038, 239.893462469734));
            temPoints.Add(new Point(379.787169352387, 243.186440677966));
            temPoints.Add(new Point(376.138643964731, 246.52784503632));
            temPoints.Add(new Point(372.68470659775, 249.820823244552));
            temPoints.Add(new Point(369.376710246275, 253.210653753027));
            temPoints.Add(new Point(366.11736089997, 256.600484261501));
            temPoints.Add(new Point(363.00395256917, 259.941888619855));
            temPoints.Add(new Point(360.036485253877, 263.283292978208));
            temPoints.Add(new Point(357.166311948921, 266.52784503632));
            temPoints.Add(new Point(354.393432654302, 269.820823244552));
            temPoints.Add(new Point(351.863788385527, 273.065375302663));
            temPoints.Add(new Point(349.334144116753, 276.261501210654));
            temPoints.Add(new Point(346.999087868653, 279.312348668281));
            temPoints.Add(new Point(344.955913651566, 282.314769975787));
            temPoints.Add(new Point(343.058680449985, 285.220338983051));
            temPoints.Add(new Point(341.453329279416, 287.980629539952));
            temPoints.Add(new Point(340.091213134691, 290.595641646489));
            temPoints.Add(new Point(338.97233201581, 292.9200968523));
            temPoints.Add(new Point(338.048038917604, 295.099273607748));
            temPoints.Add(new Point(337.512921860748, 297.084745762712));
            temPoints.Add(new Point(337.172392824567, 298.876513317191));
            temPoints.Add(new Point(337.075098814229, 300.571428571429));
            temPoints.Add(new Point(337.269686834904, 302.072639225182));
            temPoints.Add(new Point(337.610215871085, 303.428571428571));
            temPoints.Add(new Point(338.19397993311, 304.639225181598));
            temPoints.Add(new Point(339.069626026148, 305.801452784504));
            temPoints.Add(new Point(340.188507145029, 306.818401937046));
            temPoints.Add(new Point(341.599270294922, 307.738498789346));
            temPoints.Add(new Point(343.399209486166, 308.513317191283));
            temPoints.Add(new Point(345.539677713591, 309.191283292978));
            temPoints.Add(new Point(348.069321982365, 309.72397094431));
            temPoints.Add(new Point(351.182730313165, 310.1598062954));
            temPoints.Add(new Point(354.685314685315, 310.401937046005));
            temPoints.Add(new Point(358.577075098814, 310.498789346247));
            temPoints.Add(new Point(362.906658558832, 310.353510895884));
            temPoints.Add(new Point(367.674065065369, 310.111380145278));
            temPoints.Add(new Point(372.976588628763, 309.772397094431));
            temPoints.Add(new Point(378.668288233506, 309.384987893462));
            temPoints.Add(new Point(384.70051687443, 308.80387409201));
            temPoints.Add(new Point(390.830039525692, 308.174334140436));
            temPoints.Add(new Point(397.154150197628, 307.496368038741));
            temPoints.Add(new Point(403.770142900578, 306.818401937046));
            temPoints.Add(new Point(410.386135603527, 306.140435835351));
            temPoints.Add(new Point(417.050775311645, 305.559322033898));
            temPoints.Add(new Point(423.374885983582, 304.929782082324));
            temPoints.Add(new Point(429.698996655518, 304.445520581114));
            temPoints.Add(new Point(435.779872301611, 304.106537530266));
            temPoints.Add(new Point(441.763453937367, 303.912832929782));
            temPoints.Add(new Point(447.406506536941, 303.864406779661));
            temPoints.Add(new Point(452.757677105503, 303.961259079903));
            temPoints.Add(new Point(457.671024627546, 304.154963680387));
            temPoints.Add(new Point(462.097902097902, 304.445520581114));
            temPoints.Add(new Point(466.135603526908, 304.832929782082));
            temPoints.Add(new Point(469.394952873214, 305.123486682809));
            temPoints.Add(new Point(472.021891152326, 305.607748184019));
            temPoints.Add(new Point(473.627242322894, 305.510895883777));
            temPoints.Add(new Point(475.038005472788, 305.753026634383));
            temPoints.Add(new Point(475.038005472788, 305.753026634383));
            temPoints.Add(new Point(475.427181514138, 305.075060532688));
            strokes.Add(temPoints);
            count2++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(367.965947096382, 195.777239709443));
            temPoints.Add(new Point(367.868653086044, 194.760290556901));
            temPoints.Add(new Point(368.063241106719, 193.937046004843));
            temPoints.Add(new Point(367.965947096382, 192.774818401937));
            temPoints.Add(new Point(367.820006080876, 191.56416464891));
            temPoints.Add(new Point(368.209182122226, 190.401937046005));
            temPoints.Add(new Point(368.549711158407, 188.997578692494));
            temPoints.Add(new Point(369.230769230769, 187.690072639225));
            temPoints.Add(new Point(369.911827303132, 186.043583535109));
            temPoints.Add(new Point(370.982061416844, 184.493946731235));
            temPoints.Add(new Point(371.90635451505, 182.605326876513));
            temPoints.Add(new Point(373.317117664944, 180.910411622276));
            temPoints.Add(new Point(374.679233809669, 178.876513317191));
            temPoints.Add(new Point(376.527820006081, 177.181598062954));
            temPoints.Add(new Point(378.376406202493, 175.19612590799));
            temPoints.Add(new Point(380.662815445424, 173.501210653753));
            temPoints.Add(new Point(383.095165703861, 171.757869249395));
            temPoints.Add(new Point(385.770750988142, 170.208232445521));
            temPoints.Add(new Point(388.689571298267, 168.755447941889));
            temPoints.Add(new Point(391.754332623898, 167.496368038741));
            temPoints.Add(new Point(394.916387959866, 166.334140435835));
            temPoints.Add(new Point(398.175737306172, 165.365617433414));
            temPoints.Add(new Point(401.386439647309, 164.687651331719));
            temPoints.Add(new Point(404.645788993615, 164.25181598063));
            temPoints.Add(new Point(407.856491334752, 163.912832929782));
            temPoints.Add(new Point(411.164487686227, 163.864406779661));
            temPoints.Add(new Point(414.472484037701, 164.009685230024));
            temPoints.Add(new Point(417.877774399514, 164.348668280872));
            temPoints.Add(new Point(421.185770750988, 164.832929782082));
            temPoints.Add(new Point(424.445120097294, 165.510895883777));
            temPoints.Add(new Point(427.655822438431, 166.430992736077));
            temPoints.Add(new Point(430.769230769231, 167.544794188862));
            temPoints.Add(new Point(433.639404074187, 168.80387409201));
            temPoints.Add(new Point(436.266342353299, 170.256658595642));
            temPoints.Add(new Point(438.55275159623, 171.854721549637));
            temPoints.Add(new Point(440.693219823655, 173.646489104116));
            temPoints.Add(new Point(442.541806020067, 175.728813559322));
            temPoints.Add(new Point(444.195804195804, 178.053268765133));
            temPoints.Add(new Point(445.50927333536, 180.523002421308));
            temPoints.Add(new Point(446.530860443904, 183.138014527845));
            temPoints.Add(new Point(447.309212526604, 185.946731234867));
            temPoints.Add(new Point(447.795682578291, 188.852300242131));
            temPoints.Add(new Point(447.941623593797, 192.048426150121));
            temPoints.Add(new Point(447.795682578291, 195.244552058111));
            temPoints.Add(new Point(447.309212526604, 198.489104116223));
            temPoints.Add(new Point(446.579507449073, 201.733656174334));
            temPoints.Add(new Point(445.557920340529, 205.026634382567));
            temPoints.Add(new Point(444.195804195804, 208.464891041162));
            temPoints.Add(new Point(442.590453025236, 212));
            temPoints.Add(new Point(440.644572818486, 215.583535108959));
            temPoints.Add(new Point(438.455457585892, 219.167070217918));
            temPoints.Add(new Point(436.023107327455, 222.847457627119));
            temPoints.Add(new Point(433.201581027668, 226.624697336562));
            temPoints.Add(new Point(430.088172696868, 230.498789346247));
            temPoints.Add(new Point(426.731529340225, 234.372881355932));
            temPoints.Add(new Point(423.180297962907, 238.392251815981));
            temPoints.Add(new Point(419.483125570082, 242.411622276029));
            temPoints.Add(new Point(415.68865916692, 246.479418886199));
            temPoints.Add(new Point(411.79689875342, 250.595641646489));
            temPoints.Add(new Point(407.905138339921, 254.663438256659));
            temPoints.Add(new Point(403.916083916084, 258.682808716707));
            temPoints.Add(new Point(400.072970507753, 262.750605326877));
            temPoints.Add(new Point(396.229857099422, 266.673123486683));
            temPoints.Add(new Point(392.532684706598, 270.498789346247));
            temPoints.Add(new Point(388.932806324111, 274.130750605327));
            temPoints.Add(new Point(385.576162967467, 277.714285714286));
            temPoints.Add(new Point(382.36546062633, 281.10411622276));
            temPoints.Add(new Point(379.349346305868, 284.397094430993));
            temPoints.Add(new Point(376.57646701125, 287.593220338983));
            temPoints.Add(new Point(373.998175737306, 290.595641646489));
            temPoints.Add(new Point(371.614472484038, 293.452784503632));
            temPoints.Add(new Point(369.328063241107, 296.213075060533));
            temPoints.Add(new Point(367.138948008513, 298.876513317191));
            temPoints.Add(new Point(365.047126786257, 301.443099273608));
            temPoints.Add(new Point(363.101246579507, 303.864406779661));
            temPoints.Add(new Point(361.301307388264, 306.285714285714));
            temPoints.Add(new Point(359.744603222864, 308.561743341404));
            temPoints.Add(new Point(358.382487078139, 310.740920096852));
            temPoints.Add(new Point(357.214958954089, 312.774818401937));
            temPoints.Add(new Point(356.436606871389, 314.663438256659));
            temPoints.Add(new Point(355.901489814533, 316.309927360775));
            temPoints.Add(new Point(355.706901793858, 317.859564164649));
            temPoints.Add(new Point(355.804195804196, 319.167070217918));
            temPoints.Add(new Point(356.339312861052, 320.377723970944));
            temPoints.Add(new Point(357.166311948921, 321.346246973366));
            temPoints.Add(new Point(358.382487078139, 322.217917675545));
            temPoints.Add(new Point(359.987838248708, 322.944309927361));
            temPoints.Add(new Point(361.982365460626, 323.525423728814));
            temPoints.Add(new Point(364.317421708726, 323.961259079903));
            temPoints.Add(new Point(366.993006993007, 324.25181598063));
            temPoints.Add(new Point(370.009121313469, 324.348668280872));
            temPoints.Add(new Point(373.365764670112, 324.300242130751));
            temPoints.Add(new Point(377.160231073275, 324.058111380145));
            temPoints.Add(new Point(381.295226512618, 323.622276029056));
            temPoints.Add(new Point(385.722103982974, 323.089588377724));
            temPoints.Add(new Point(390.538157494679, 322.314769975787));
            temPoints.Add(new Point(395.597446032229, 321.491525423729));
            temPoints.Add(new Point(400.997263605959, 320.61985472155));
            temPoints.Add(new Point(406.688963210702, 319.651331719128));
            temPoints.Add(new Point(412.429309820614, 318.682808716707));
            temPoints.Add(new Point(418.218303435695, 317.714285714286));
            temPoints.Add(new Point(423.910003040438, 316.842615012107));
            temPoints.Add(new Point(429.504408634843, 316.067796610169));
            temPoints.Add(new Point(435.001520218911, 315.389830508475));
            temPoints.Add(new Point(440.352690787473, 314.857142857143));
            temPoints.Add(new Point(445.411979325023, 314.469733656174));
            temPoints.Add(new Point(449.984797810885, 314.227602905569));
            temPoints.Add(new Point(454.314381270903, 314.130750605327));
            temPoints.Add(new Point(458.108847674065, 314.227602905569));
            temPoints.Add(new Point(461.465491030708, 314.421307506053));
            temPoints.Add(new Point(464.238370325327, 314.760290556901));
            temPoints.Add(new Point(466.42748555792, 315.099273607748));
            temPoints.Add(new Point(468.081483733658, 315.535108958838));
            temPoints.Add(new Point(469.200364852539, 315.825665859564));
            temPoints.Add(new Point(470.221951961082, 316.406779661017));
            temPoints.Add(new Point(470.221951961082, 316.406779661017));
            temPoints.Add(new Point(470.903010033445, 316.891041162228));
            temPoints.Add(new Point(470.903010033445, 316.891041162228));
            temPoints.Add(new Point(470.903010033445, 316.891041162228));
            strokes.Add(temPoints);
            count2++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            
            #endregion
            #region 3
            name = "3";
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(344.03162055336, 146.09200968523));
            temPoints.Add(new Point(345.539677713591, 145.559322033898));
            temPoints.Add(new Point(347.242322894497, 144.542372881356));
            temPoints.Add(new Point(349.43143812709, 143.476997578692));
            temPoints.Add(new Point(351.961082395865, 142.024213075061));
            temPoints.Add(new Point(354.977196716327, 140.377723970944));
            temPoints.Add(new Point(358.771663119489, 138.634382566586));
            temPoints.Add(new Point(362.858011553664, 136.503631961259));
            temPoints.Add(new Point(367.576771055032, 134.421307506053));
            temPoints.Add(new Point(372.2955305564, 132.048426150121));
            temPoints.Add(new Point(377.598054119793, 129.820823244552));
            temPoints.Add(new Point(382.851930678018, 127.351089588378));
            temPoints.Add(new Point(388.884159318942, 125.365617433414));
            temPoints.Add(new Point(395.013681970204, 123.428571428571));
            temPoints.Add(new Point(401.678321678322, 122.072639225182));
            temPoints.Add(new Point(408.34296138644, 121.007263922518));
            temPoints.Add(new Point(415.250836120401, 120.377723970944));
            temPoints.Add(new Point(422.256004864701, 120.329297820823));
            temPoints.Add(new Point(429.261173609, 120.765133171913));
            temPoints.Add(new Point(436.266342353299, 121.685230024213));
            temPoints.Add(new Point(442.979629066586, 122.944309927361));
            temPoints.Add(new Point(449.352386743691, 124.493946731235));
            temPoints.Add(new Point(455.530556400122, 126.237288135593));
            temPoints.Add(new Point(461.319550015202, 128.222760290557));
            temPoints.Add(new Point(466.768014594102, 130.353510895884));
            temPoints.Add(new Point(471.632715110976, 132.484261501211));
            temPoints.Add(new Point(476.156886591669, 134.808716707022));
            temPoints.Add(new Point(480, 137.133171912833));
            temPoints.Add(new Point(483.50258437215, 139.554479418886));
            temPoints.Add(new Point(486.324110671937, 141.975786924939));
            temPoints.Add(new Point(488.51322590453, 144.493946731235));
            temPoints.Add(new Point(489.923989054424, 147.157384987893));
            temPoints.Add(new Point(490.702341137124, 149.917675544794));
            temPoints.Add(new Point(490.702341137124, 152.774818401937));
            temPoints.Add(new Point(489.923989054424, 155.728813559322));
            temPoints.Add(new Point(488.318637883855, 158.82808716707));
            temPoints.Add(new Point(485.886287625418, 162.169491525424));
            temPoints.Add(new Point(482.578291273943, 165.607748184019));
            temPoints.Add(new Point(478.540589844938, 169.142857142857));
            temPoints.Add(new Point(473.821830343569, 172.581113801453));
            temPoints.Add(new Point(468.422012769839, 176.116222760291));
            temPoints.Add(new Point(462.19519610824, 179.602905569007));
            temPoints.Add(new Point(455.384615384615, 182.944309927361));
            temPoints.Add(new Point(448.184858619641, 186.188861985472));
            temPoints.Add(new Point(440.693219823655, 189.239709443099));
            temPoints.Add(new Point(432.958346001824, 192.096852300242));
            temPoints.Add(new Point(425.174825174825, 194.905569007264));
            temPoints.Add(new Point(417.342657342657, 197.520581113801));
            temPoints.Add(new Point(409.656430525996, 199.893462469734));
            temPoints.Add(new Point(402.213438735178, 202.121065375303));
            temPoints.Add(new Point(395.15962298571, 204.106537530266));
            temPoints.Add(new Point(388.592277287929, 205.801452784504));
            temPoints.Add(new Point(382.657342657343, 207.254237288136));
            temPoints.Add(new Point(377.500760109456, 208.416464891041));
            temPoints.Add(new Point(373.0738826391, 209.28813559322));
            temPoints.Add(new Point(369.376710246275, 209.869249394673));
            temPoints.Add(new Point(366.50653694132, 210.256658595642));
            temPoints.Add(new Point(364.609303739738, 210.401937046005));
            temPoints.Add(new Point(363.539069626026, 210.353510895884));
            temPoints.Add(new Point(363.539069626026, 210.353510895884));
            temPoints.Add(new Point(364.122833688051, 209.627118644068));
            temPoints.Add(new Point(365.72818485862, 208.900726392252));
            temPoints.Add(new Point(368.160535117057, 208.029055690073));
            temPoints.Add(new Point(371.565825478869, 206.963680387409));
            temPoints.Add(new Point(375.749467923381, 205.704600484262));
            temPoints.Add(new Point(380.760109455762, 204.203389830508));
            temPoints.Add(new Point(386.597750076011, 202.750605326876));
            temPoints.Add(new Point(393.019154758285, 201.200968523002));
            temPoints.Add(new Point(399.975676497416, 199.651331719128));
            temPoints.Add(new Point(407.17543326239, 198.150121065375));
            temPoints.Add(new Point(414.569778048039, 196.842615012107));
            temPoints.Add(new Point(422.110063849194, 195.728813559322));
            temPoints.Add(new Point(429.65034965035, 194.905569007264));
            temPoints.Add(new Point(437.190635451505, 194.324455205811));
            temPoints.Add(new Point(444.487686226817, 193.937046004843));
            temPoints.Add(new Point(451.492854971116, 193.985472154964));
            temPoints.Add(new Point(458.206141684403, 194.372881355932));
            temPoints.Add(new Point(464.432958346002, 195.050847457627));
            temPoints.Add(new Point(470.124657950745, 196.116222760291));
            temPoints.Add(new Point(475.183946488294, 197.569007263923));
            temPoints.Add(new Point(479.61082395865, 199.26392251816));
            temPoints.Add(new Point(483.405290361812, 201.346246973366));
            temPoints.Add(new Point(486.518698692612, 203.573849878935));
            temPoints.Add(new Point(488.853754940711, 206.043583535109));
            temPoints.Add(new Point(490.45910611128, 208.610169491525));
            temPoints.Add(new Point(491.432046214655, 211.370460048426));
            temPoints.Add(new Point(491.869869261174, 214.227602905569));
            temPoints.Add(new Point(491.529340224992, 217.181598062954));
            temPoints.Add(new Point(490.653694131955, 220.280871670702));
            temPoints.Add(new Point(489.145636971724, 223.525423728814));
            temPoints.Add(new Point(487.102462754637, 226.915254237288));
            temPoints.Add(new Point(484.329583460018, 230.353510895884));
            temPoints.Add(new Point(481.118881118881, 233.937046004843));
            temPoints.Add(new Point(477.324414715719, 237.520581113801));
            temPoints.Add(new Point(472.994831255701, 241.10411622276));
            temPoints.Add(new Point(468.227424749164, 244.687651331719));
            temPoints.Add(new Point(462.973548190939, 248.319612590799));
            temPoints.Add(new Point(457.13590757069, 251.951573849879));
            temPoints.Add(new Point(450.811796898753, 255.63196125908));
            temPoints.Add(new Point(444.098510185467, 259.312348668281));
            temPoints.Add(new Point(436.655518394649, 262.89588377724));
            temPoints.Add(new Point(428.628762541806, 266.52784503632));
            temPoints.Add(new Point(419.920948616601, 270.1598062954));
            temPoints.Add(new Point(410.434782608696, 273.694915254237));
            temPoints.Add(new Point(400.510793554272, 277.181598062954));
            temPoints.Add(new Point(390.100334448161, 280.571428571429));
            temPoints.Add(new Point(379.154758285193, 283.912832929782));
            temPoints.Add(new Point(368.160535117057, 287.302663438257));
            temPoints.Add(new Point(357.409546974764, 290.547215496368));
            temPoints.Add(new Point(347.047734873822, 293.743341404358));
            temPoints.Add(new Point(337.221039829735, 296.600484261501));
            temPoints.Add(new Point(328.707813925205, 299.699757869249));
            temPoints.Add(new Point(320.7783520827, 302.072639225182));
            temPoints.Add(new Point(314.454241410763, 304.397094430993));
            temPoints.Add(new Point(309.249011857708, 305.898305084746));
            temPoints.Add(new Point(305.308604439039, 306.915254237288));
            strokes.Add(temPoints);
            count3++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(370.738826391, 146.140435835351));
            temPoints.Add(new Point(369.863180297963, 145.462469733656));
            temPoints.Add(new Point(369.863180297963, 145.462469733656));
            temPoints.Add(new Point(369.57129826695, 144.300242130751));
            temPoints.Add(new Point(369.619945272119, 143.38014527845));
            temPoints.Add(new Point(370.155062328975, 142.411622276029));
            temPoints.Add(new Point(370.933414411675, 141.249394673123));
            temPoints.Add(new Point(372.052295530556, 140.038740920097));
            temPoints.Add(new Point(373.414411675281, 138.440677966102));
            temPoints.Add(new Point(375.311644876862, 136.98789346247));
            temPoints.Add(new Point(377.403466099118, 135.19612590799));
            temPoints.Add(new Point(380.127698388568, 133.598062953995));
            temPoints.Add(new Point(383.046518698693, 131.709443099274));
            temPoints.Add(new Point(386.64639708118, 130.111380145278));
            temPoints.Add(new Point(390.538157494679, 128.36803874092));
            temPoints.Add(new Point(395.013681970204, 126.769975786925));
            temPoints.Add(new Point(399.829735481909, 125.220338983051));
            temPoints.Add(new Point(405.034965034965, 123.864406779661));
            temPoints.Add(new Point(410.580723624202, 122.605326876513));
            temPoints.Add(new Point(416.612952265126, 121.53995157385));
            temPoints.Add(new Point(422.839768926725, 120.523002421307));
            temPoints.Add(new Point(429.261173609, 119.74818401937));
            temPoints.Add(new Point(435.779872301611, 119.118644067797));
            temPoints.Add(new Point(442.298570994223, 118.82808716707));
            temPoints.Add(new Point(448.817269686835, 118.634382566586));
            temPoints.Add(new Point(455.433262389784, 118.682808716707));
            temPoints.Add(new Point(461.80602006689, 118.82808716707));
            temPoints.Add(new Point(468.032836728489, 119.167070217918));
            temPoints.Add(new Point(473.821830343569, 119.845036319613));
            temPoints.Add(new Point(479.464882943144, 120.668280871671));
            temPoints.Add(new Point(484.718759501368, 121.685230024213));
            temPoints.Add(new Point(489.729401033749, 122.847457627119));
            temPoints.Add(new Point(494.302219519611, 124.203389830508));
            temPoints.Add(new Point(498.437214958954, 125.753026634383));
            temPoints.Add(new Point(502.037093341441, 127.44794188862));
            temPoints.Add(new Point(505.247795682578, 129.433414043584));
            temPoints.Add(new Point(507.923380966859, 131.515738498789));
            temPoints.Add(new Point(510.112496199453, 133.888619854722));
            temPoints.Add(new Point(511.669200364852, 136.503631961259));
            temPoints.Add(new Point(512.739434478565, 139.26392251816));
            temPoints.Add(new Point(513.177257525084, 142.266343825666));
            temPoints.Add(new Point(512.982669504409, 145.462469733656));
            temPoints.Add(new Point(512.107023411371, 148.707021791768));
            temPoints.Add(new Point(510.550319245971, 152.193704600484));
            temPoints.Add(new Point(508.26391000304, 155.535108958838));
            temPoints.Add(new Point(505.442383703253, 159.070217917676));
            temPoints.Add(new Point(501.939799331104, 162.702179176755));
            temPoints.Add(new Point(497.950744907267, 166.382566585956));
            temPoints.Add(new Point(493.329279416236, 169.966101694915));
            temPoints.Add(new Point(488.318637883855, 173.549636803874));
            temPoints.Add(new Point(482.821526299787, 177.036319612591));
            temPoints.Add(new Point(477.032532684707, 180.474576271186));
            temPoints.Add(new Point(470.951657038614, 183.767554479419));
            temPoints.Add(new Point(464.627546366677, 186.915254237288));
            temPoints.Add(new Point(458.108847674065, 189.72397094431));
            temPoints.Add(new Point(451.444207965947, 192.43583535109));
            temPoints.Add(new Point(444.779568257829, 194.905569007264));
            temPoints.Add(new Point(438.212222560049, 197.181598062954));
            temPoints.Add(new Point(431.742170872606, 199.215496368039));
            temPoints.Add(new Point(425.515354211006, 201.055690072639));
            temPoints.Add(new Point(419.677713590757, 202.556900726392));
            temPoints.Add(new Point(414.472484037701, 203.767554479419));
            temPoints.Add(new Point(409.851018546671, 204.73607748184));
            temPoints.Add(new Point(405.861964122834, 205.414043583535));
            temPoints.Add(new Point(402.602614776528, 205.849878934625));
            temPoints.Add(new Point(400.024323502584, 206.043583535109));
            temPoints.Add(new Point(398.224384311341, 206.09200968523));
            temPoints.Add(new Point(397.008209182122, 205.995157384988));
            temPoints.Add(new Point(396.375798114929, 205.753026634383));
            temPoints.Add(new Point(396.375798114929, 205.753026634383));
            temPoints.Add(new Point(396.862268166616, 204.832929782082));
            temPoints.Add(new Point(397.932502280328, 204.154963680387));
            temPoints.Add(new Point(399.683794466403, 203.331719128329));
            temPoints.Add(new Point(402.164791730009, 202.363196125908));
            temPoints.Add(new Point(405.278200060809, 201.346246973366));
            temPoints.Add(new Point(408.975372453633, 200.232445520581));
            temPoints.Add(new Point(413.35360291882, 199.021791767554));
            temPoints.Add(new Point(418.169656430526, 197.762711864407));
            temPoints.Add(new Point(423.569474004257, 196.455205811138));
            temPoints.Add(new Point(429.407114624506, 195.19612590799));
            temPoints.Add(new Point(435.633931286105, 193.985472154964));
            temPoints.Add(new Point(442.055335968379, 192.774818401937));
            temPoints.Add(new Point(448.768622681666, 191.56416464891));
            temPoints.Add(new Point(455.871085436303, 190.450363196126));
            temPoints.Add(new Point(463.168136211614, 189.530266343826));
            temPoints.Add(new Point(470.562480997264, 188.707021791768));
            temPoints.Add(new Point(477.956825782913, 188.077481840194));
            temPoints.Add(new Point(485.399817573731, 187.641646489104));
            temPoints.Add(new Point(492.599574338705, 187.544794188862));
            temPoints.Add(new Point(499.604743083004, 187.738498789346));
            temPoints.Add(new Point(506.220735785953, 188.271186440678));
            temPoints.Add(new Point(512.447552447552, 189.191283292978));
            temPoints.Add(new Point(518.33384007297, 190.595641646489));
            temPoints.Add(new Point(523.830951657039, 192.43583535109));
            temPoints.Add(new Point(528.744299179082, 194.71186440678));
            temPoints.Add(new Point(533.122529644269, 197.326876513317));
            temPoints.Add(new Point(536.916996047431, 200.280871670702));
            temPoints.Add(new Point(540.273639404074, 203.622276029056));
            temPoints.Add(new Point(542.949224688355, 207.108958837772));
            temPoints.Add(new Point(545.138339920949, 210.837772397094));
            temPoints.Add(new Point(546.500456065673, 214.615012106538));
            temPoints.Add(new Point(547.278808148373, 218.682808716707));
            temPoints.Add(new Point(547.327455153542, 222.847457627119));
            temPoints.Add(new Point(546.743691091517, 227.060532687651));
            temPoints.Add(new Point(545.430221951961, 231.418886198547));
            temPoints.Add(new Point(543.435694740043, 235.777239709443));
            temPoints.Add(new Point(540.711462450593, 240.18401937046));
            temPoints.Add(new Point(537.354819093949, 244.73607748184));
            temPoints.Add(new Point(533.414411675281, 249.384987893462));
            temPoints.Add(new Point(528.841593189419, 254.033898305085));
            temPoints.Add(new Point(523.539069626026, 258.585956416465));
            temPoints.Add(new Point(517.798723016114, 263.186440677966));
            temPoints.Add(new Point(511.620553359684, 267.641646489104));
            temPoints.Add(new Point(505.004560656735, 272.048426150121));
            temPoints.Add(new Point(497.853450896929, 276.358353510896));
            temPoints.Add(new Point(490.410459106111, 280.61985472155));
            temPoints.Add(new Point(482.529644268775, 284.687651331719));
            temPoints.Add(new Point(474.259653390088, 288.610169491525));
            temPoints.Add(new Point(465.551839464883, 292.338983050847));
            temPoints.Add(new Point(456.454849498328, 295.922518159806));
            temPoints.Add(new Point(446.871389480085, 299.457627118644));
            temPoints.Add(new Point(436.947400425661, 302.847457627119));
            temPoints.Add(new Point(427.072058376406, 306.140435835351));
            temPoints.Add(new Point(417.050775311645, 309.239709443099));
            temPoints.Add(new Point(407.224080267559, 312.048426150121));
            temPoints.Add(new Point(397.88385527516, 314.808716707022));
            temPoints.Add(new Point(389.516570386136, 317.423728813559));
            temPoints.Add(new Point(381.927637579811, 319.74818401937));
            temPoints.Add(new Point(375.749467923381, 322.169491525424));
            temPoints.Add(new Point(370.252356339313, 323.961259079903));
            temPoints.Add(new Point(366.409242930982, 325.801452784504));
            temPoints.Add(new Point(363.295834600182, 326.915254237288));
            temPoints.Add(new Point(361.544542414108, 327.93220338983));
            strokes.Add(temPoints);
            count3++;
            #endregion
            #region 4

            name = "4";
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(400.121617512922, 121.927360774818));
            temPoints.Add(new Point(400.121617512922, 121.927360774818));
            temPoints.Add(new Point(400.121617512922, 121.927360774818));
            temPoints.Add(new Point(400.316205533597, 122.363196125908));
            temPoints.Add(new Point(400.316205533597, 122.363196125908));
            temPoints.Add(new Point(400.316205533597, 123.089588377724));
            temPoints.Add(new Point(400.072970507753, 123.525423728814));
            temPoints.Add(new Point(400.218911523259, 124.445520581114));
            temPoints.Add(new Point(400.024323502584, 125.414043583535));
            temPoints.Add(new Point(400.024323502584, 126.769975786925));
            temPoints.Add(new Point(399.781088476741, 128.222760290557));
            temPoints.Add(new Point(399.586500456066, 130.014527845036));
            temPoints.Add(new Point(399.294618425053, 132.048426150121));
            temPoints.Add(new Point(399.002736394041, 134.421307506053));
            temPoints.Add(new Point(398.66220735786, 137.036319612591));
            temPoints.Add(new Point(398.27303131651, 140.038740920097));
            temPoints.Add(new Point(397.835208269991, 143.186440677966));
            temPoints.Add(new Point(397.397385223472, 146.576271186441));
            temPoints.Add(new Point(396.862268166616, 150.305084745763));
            temPoints.Add(new Point(396.32715110976, 154.372881355932));
            temPoints.Add(new Point(395.743387047735, 158.634382566586));
            temPoints.Add(new Point(395.208269990879, 163.38014527845));
            temPoints.Add(new Point(394.575858923685, 168.271186440678));
            temPoints.Add(new Point(393.99209486166, 173.35593220339));
            temPoints.Add(new Point(393.311036789298, 178.585956416465));
            temPoints.Add(new Point(392.775919732441, 184.009685230024));
            temPoints.Add(new Point(392.240802675585, 189.433414043584));
            temPoints.Add(new Point(391.802979629067, 195.099273607748));
            temPoints.Add(new Point(391.365156582548, 200.571428571429));
            temPoints.Add(new Point(391.121921556704, 205.849878934625));
            temPoints.Add(new Point(390.927333536029, 210.934624697337));
            temPoints.Add(new Point(391.024627546367, 215.970944309927));
            temPoints.Add(new Point(391.316509577379, 220.716707021792));
            temPoints.Add(new Point(391.851626634235, 225.317191283293));
            temPoints.Add(new Point(392.532684706598, 229.627118644068));
            temPoints.Add(new Point(393.505624809973, 233.694915254237));
            temPoints.Add(new Point(394.721799939191, 237.47215496368));
            temPoints.Add(new Point(396.229857099422, 241.10411622276));
            temPoints.Add(new Point(397.981149285497, 244.397094430993));
            temPoints.Add(new Point(400.024323502584, 247.44794188862));
            temPoints.Add(new Point(402.359379750684, 250.208232445521));
            temPoints.Add(new Point(404.937671024628, 252.629539951574));
            temPoints.Add(new Point(407.759197324415, 254.615012106538));
            temPoints.Add(new Point(410.775311644877, 256.261501210654));
            temPoints.Add(new Point(413.986013986014, 257.520581113801));
            temPoints.Add(new Point(417.294010337489, 258.440677966102));
            temPoints.Add(new Point(420.796594709638, 259.021791767554));
            temPoints.Add(new Point(424.299179081788, 259.26392251816));
            temPoints.Add(new Point(427.899057464275, 259.215496368039));
            temPoints.Add(new Point(431.547582851931, 258.82808716707));
            temPoints.Add(new Point(435.244755244755, 258.198547215496));
            temPoints.Add(new Point(438.893280632411, 257.278450363196));
            temPoints.Add(new Point(442.347217999392, 256.067796610169));
            temPoints.Add(new Point(445.801155366373, 254.615012106538));
            temPoints.Add(new Point(449.01185770751, 252.823244552058));
            temPoints.Add(new Point(452.027972027972, 250.740920096852));
            temPoints.Add(new Point(454.703557312253, 248.416464891041));
            temPoints.Add(new Point(457.13590757069, 245.849878934625));
            temPoints.Add(new Point(459.373669808452, 242.992736077482));
            temPoints.Add(new Point(461.368197020371, 240.038740920097));
            temPoints.Add(new Point(463.168136211614, 236.842615012107));
            temPoints.Add(new Point(464.773487382183, 233.501210653753));
            temPoints.Add(new Point(466.281544542414, 230.111380145278));
            temPoints.Add(new Point(467.643660687139, 226.576271186441));
            temPoints.Add(new Point(468.859835816358, 222.799031476998));
            temPoints.Add(new Point(469.978716935239, 218.876513317191));
            temPoints.Add(new Point(470.903010033445, 214.857142857143));
            temPoints.Add(new Point(471.778656126482, 210.740920096852));
            temPoints.Add(new Point(472.557008209182, 206.52784503632));
            temPoints.Add(new Point(473.140772271207, 202.266343825666));
            temPoints.Add(new Point(473.529948312557, 197.956416464891));
            temPoints.Add(new Point(473.773183338401, 193.646489104116));
            temPoints.Add(new Point(473.919124353907, 189.384987893462));
            temPoints.Add(new Point(474.016418364244, 185.317191283293));
            temPoints.Add(new Point(473.967771359076, 181.346246973366));
            temPoints.Add(new Point(473.919124353907, 177.569007263923));
            temPoints.Add(new Point(473.821830343569, 174.082324455206));
            temPoints.Add(new Point(473.675889328063, 170.740920096852));
            temPoints.Add(new Point(473.529948312557, 167.641646489104));
            temPoints.Add(new Point(473.481301307388, 164.929782082324));
            temPoints.Add(new Point(473.432654302219, 162.605326876513));
            temPoints.Add(new Point(473.432654302219, 160.668280871671));
            temPoints.Add(new Point(473.481301307388, 159.070217917676));
            temPoints.Add(new Point(473.578595317726, 157.762711864407));
            temPoints.Add(new Point(473.724536333232, 156.697336561743));
            temPoints.Add(new Point(473.967771359076, 156.019370460048));
            temPoints.Add(new Point(474.308300395257, 155.583535108959));
            temPoints.Add(new Point(474.308300395257, 155.583535108959));
            temPoints.Add(new Point(474.989358467619, 155.486682808717));
            temPoints.Add(new Point(474.989358467619, 155.486682808717));
            temPoints.Add(new Point(475.621769534813, 156.503631961259));
            temPoints.Add(new Point(475.913651565825, 157.520581113801));
            temPoints.Add(new Point(476.156886591669, 158.876513317191));
            temPoints.Add(new Point(476.351474612344, 160.668280871671));
            temPoints.Add(new Point(476.49741562785, 162.847457627119));
            temPoints.Add(new Point(476.594709638188, 165.559322033898));
            temPoints.Add(new Point(476.49741562785, 168.755447941889));
            temPoints.Add(new Point(476.351474612344, 172.387409200969));
            temPoints.Add(new Point(476.156886591669, 176.358353510896));
            temPoints.Add(new Point(475.816357555488, 180.668280871671));
            temPoints.Add(new Point(475.427181514138, 185.268765133172));
            temPoints.Add(new Point(475.086652477957, 190.256658595642));
            temPoints.Add(new Point(474.600182426269, 195.583535108959));
            temPoints.Add(new Point(474.113712374582, 200.910411622276));
            temPoints.Add(new Point(473.578595317726, 206.285714285714));
            temPoints.Add(new Point(472.946184250532, 211.806295399516));
            temPoints.Add(new Point(472.313773183338, 217.375302663438));
            temPoints.Add(new Point(471.730009121313, 222.992736077482));
            temPoints.Add(new Point(471.09759805412, 228.755447941889));
            temPoints.Add(new Point(470.465186986926, 234.372881355932));
            temPoints.Add(new Point(469.881422924901, 239.893462469734));
            temPoints.Add(new Point(469.346305868045, 245.414043583535));
            temPoints.Add(new Point(468.908482821526, 250.886198547215));
            temPoints.Add(new Point(468.567953785345, 256.406779661017));
            temPoints.Add(new Point(468.324718759501, 261.830508474576));
            temPoints.Add(new Point(468.178777743995, 267.060532687651));
            temPoints.Add(new Point(468.081483733658, 272.048426150121));
            temPoints.Add(new Point(467.98418972332, 276.891041162228));
            temPoints.Add(new Point(467.935542718151, 281.394673123487));
            temPoints.Add(new Point(467.789601702645, 285.753026634383));
            temPoints.Add(new Point(467.692307692308, 289.966101694915));
            temPoints.Add(new Point(467.546366676801, 293.937046004843));
            temPoints.Add(new Point(467.351778656126, 297.617433414044));
            temPoints.Add(new Point(467.011249619945, 301.200968523002));
            temPoints.Add(new Point(466.719367588933, 304.590799031477));
            temPoints.Add(new Point(466.42748555792, 307.93220338983));
            temPoints.Add(new Point(466.086956521739, 311.128329297821));
            temPoints.Add(new Point(465.746427485558, 314.227602905569));
            temPoints.Add(new Point(465.405898449377, 317.181598062954));
            temPoints.Add(new Point(465.065369413195, 320.038740920097));
            temPoints.Add(new Point(464.773487382183, 322.847457627119));
            temPoints.Add(new Point(464.530252356339, 325.607748184019));
            temPoints.Add(new Point(464.384311340833, 328.319612590799));
            temPoints.Add(new Point(464.238370325327, 330.934624697337));
            temPoints.Add(new Point(464.287017330496, 333.452784503632));
            temPoints.Add(new Point(464.335664335664, 335.728813559322));
            temPoints.Add(new Point(464.627546366677, 337.859564164649));
            temPoints.Add(new Point(464.919428397689, 339.602905569007));
            temPoints.Add(new Point(465.454545454545, 341.152542372881));
            temPoints.Add(new Point(466.03830951657, 342.121065375303));
            temPoints.Add(new Point(467.157190635451, 343.041162227603));
            temPoints.Add(new Point(467.935542718151, 343.186440677966));
            temPoints.Add(new Point(469.394952873214, 343.041162227603));
            temPoints.Add(new Point(470.70842201277, 342.169491525424));
            temPoints.Add(new Point(472.459714198845, 340.910411622276));
            strokes.Add(temPoints);
            count4++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(417.148069321982, 183.525423728814));
            temPoints.Add(new Point(417.148069321982, 183.525423728814));
            temPoints.Add(new Point(417.148069321982, 183.525423728814));
            temPoints.Add(new Point(417.148069321982, 183.525423728814));
            temPoints.Add(new Point(417.148069321982, 183.525423728814));
            temPoints.Add(new Point(417.050775311645, 182.750605326876));
            temPoints.Add(new Point(417.050775311645, 182.750605326876));
            temPoints.Add(new Point(416.953481301307, 182.072639225182));
            temPoints.Add(new Point(416.953481301307, 182.072639225182));
            temPoints.Add(new Point(416.953481301307, 181.152542372881));
            temPoints.Add(new Point(416.953481301307, 181.152542372881));
            temPoints.Add(new Point(417.002128306476, 180.329297820823));
            temPoints.Add(new Point(417.002128306476, 180.329297820823));
            temPoints.Add(new Point(417.099422316814, 179.845036319613));
            temPoints.Add(new Point(417.099422316814, 179.845036319613));
            temPoints.Add(new Point(417.099422316814, 179.845036319613));
            temPoints.Add(new Point(417.488598358164, 180.426150121065));
            temPoints.Add(new Point(417.63453937367, 181.007263922518));
            temPoints.Add(new Point(417.877774399514, 181.830508474576));
            temPoints.Add(new Point(418.072362420188, 182.750605326876));
            temPoints.Add(new Point(418.364244451201, 184.058111380145));
            temPoints.Add(new Point(418.510185466707, 185.414043583535));
            temPoints.Add(new Point(418.607479477045, 187.302663438257));
            temPoints.Add(new Point(418.607479477045, 189.239709443099));
            temPoints.Add(new Point(418.558832471876, 191.612590799031));
            temPoints.Add(new Point(418.364244451201, 194.130750605327));
            temPoints.Add(new Point(418.121009425357, 197.084745762712));
            temPoints.Add(new Point(417.731833384007, 200.377723970944));
            temPoints.Add(new Point(417.294010337489, 204.009685230024));
            temPoints.Add(new Point(416.710246275464, 207.883777239709));
            temPoints.Add(new Point(416.175129218607, 211.903147699758));
            temPoints.Add(new Point(415.494071146245, 216.164648910412));
            temPoints.Add(new Point(414.813013073883, 220.571428571429));
            temPoints.Add(new Point(414.13195500152, 225.123486682809));
            temPoints.Add(new Point(413.548190939495, 229.820823244552));
            temPoints.Add(new Point(412.96442687747, 234.518159806295));
            temPoints.Add(new Point(412.477956825783, 239.167070217918));
            temPoints.Add(new Point(412.137427789602, 243.81598062954));
            temPoints.Add(new Point(411.942839768927, 248.416464891041));
            temPoints.Add(new Point(411.942839768927, 252.9200968523));
            temPoints.Add(new Point(412.18607479477, 257.326876513317));
            temPoints.Add(new Point(412.721191851627, 261.53995157385));
            temPoints.Add(new Point(413.450896929158, 265.462469733656));
            temPoints.Add(new Point(414.472484037701, 269.094430992736));
            temPoints.Add(new Point(415.640012161751, 272.43583535109));
            temPoints.Add(new Point(417.148069321982, 275.438256658596));
            temPoints.Add(new Point(418.753420492551, 278.101694915254));
            temPoints.Add(new Point(420.553359683794, 280.426150121065));
            temPoints.Add(new Point(422.450592885375, 282.314769975787));
            temPoints.Add(new Point(424.493767102463, 283.864406779661));
            temPoints.Add(new Point(426.682882335056, 285.026634382567));
            temPoints.Add(new Point(428.87199756765, 285.849878934625));
            temPoints.Add(new Point(431.207053815749, 286.334140435835));
            temPoints.Add(new Point(433.542110063849, 286.479418886199));
            temPoints.Add(new Point(435.974460322286, 286.334140435835));
            temPoints.Add(new Point(438.406810580724, 285.801452784504));
            temPoints.Add(new Point(440.839160839161, 285.075060532688));
            temPoints.Add(new Point(443.222864092429, 284.058111380145));
            temPoints.Add(new Point(445.460626330192, 282.750605326877));
            temPoints.Add(new Point(447.795682578291, 281.10411622276));
            temPoints.Add(new Point(449.984797810885, 279.215496368039));
            temPoints.Add(new Point(452.076619033141, 276.98789346247));
            temPoints.Add(new Point(454.119793250228, 274.566585956416));
            temPoints.Add(new Point(455.96837944664, 271.951573849879));
            temPoints.Add(new Point(457.768318637884, 269.142857142857));
            temPoints.Add(new Point(459.373669808452, 266.140435835351));
            temPoints.Add(new Point(460.881726968683, 263.041162227603));
            temPoints.Add(new Point(462.097902097902, 259.893462469734));
            temPoints.Add(new Point(463.168136211614, 256.648910411622));
            temPoints.Add(new Point(464.043782304652, 253.35593220339));
            temPoints.Add(new Point(464.724840377014, 250.014527845036));
            temPoints.Add(new Point(465.211310428702, 246.673123486683));
            temPoints.Add(new Point(465.600486470052, 243.234866828087));
            temPoints.Add(new Point(465.746427485558, 239.893462469734));
            temPoints.Add(new Point(465.843721495895, 236.503631961259));
            temPoints.Add(new Point(465.843721495895, 233.162227602906));
            temPoints.Add(new Point(465.64913347522, 229.869249394673));
            temPoints.Add(new Point(465.503192459714, 226.721549636804));
            temPoints.Add(new Point(465.308604439039, 223.525423728814));
            temPoints.Add(new Point(465.162663423533, 220.474576271186));
            temPoints.Add(new Point(464.968075402858, 217.47215496368));
            temPoints.Add(new Point(464.822134387352, 214.518159806295));
            temPoints.Add(new Point(464.676193371846, 211.709443099274));
            temPoints.Add(new Point(464.530252356339, 209.142857142857));
            temPoints.Add(new Point(464.384311340833, 206.818401937046));
            temPoints.Add(new Point(464.238370325327, 204.784503631961));
            temPoints.Add(new Point(464.043782304652, 202.992736077482));
            temPoints.Add(new Point(463.800547278808, 201.53995157385));
            temPoints.Add(new Point(463.557312252964, 200.426150121065));
            temPoints.Add(new Point(463.314077227121, 199.602905569007));
            temPoints.Add(new Point(463.022195196108, 199.021791767554));
            temPoints.Add(new Point(463.022195196108, 199.021791767554));
            temPoints.Add(new Point(462.535725144421, 198.585956416465));
            temPoints.Add(new Point(462.535725144421, 198.585956416465));
            temPoints.Add(new Point(462.19519610824, 199.167070217918));
            temPoints.Add(new Point(462.146549103071, 199.796610169492));
            temPoints.Add(new Point(462.19519610824, 200.765133171913));
            temPoints.Add(new Point(462.341137123746, 202.024213075061));
            temPoints.Add(new Point(462.58437214959, 203.670702179177));
            temPoints.Add(new Point(462.876254180602, 205.607748184019));
            temPoints.Add(new Point(463.216783216783, 207.835351089588));
            temPoints.Add(new Point(463.605959258133, 210.353510895884));
            temPoints.Add(new Point(463.995135299483, 213.113801452785));
            temPoints.Add(new Point(464.287017330496, 216.164648910412));
            temPoints.Add(new Point(464.676193371846, 219.506053268765));
            temPoints.Add(new Point(464.919428397689, 223.041162227603));
            temPoints.Add(new Point(465.114016418364, 226.818401937046));
            temPoints.Add(new Point(465.162663423533, 230.886198547215));
            temPoints.Add(new Point(465.211310428702, 235.244552058111));
            temPoints.Add(new Point(465.065369413195, 239.845036319613));
            temPoints.Add(new Point(465.016722408027, 244.687651331719));
            temPoints.Add(new Point(464.87078139252, 249.675544794189));
            temPoints.Add(new Point(464.578899361508, 254.905569007264));
            temPoints.Add(new Point(464.238370325327, 260.377723970944));
            temPoints.Add(new Point(463.800547278808, 265.995157384988));
            temPoints.Add(new Point(463.265430221952, 271.612590799031));
            temPoints.Add(new Point(462.681666159927, 277.375302663438));
            temPoints.Add(new Point(462.000608087565, 283.234866828087));
            temPoints.Add(new Point(461.222256004865, 289.28813559322));
            temPoints.Add(new Point(460.443903922165, 295.292978208232));
            temPoints.Add(new Point(459.616904834296, 301.346246973366));
            temPoints.Add(new Point(458.789905746427, 307.399515738499));
            temPoints.Add(new Point(457.962906658559, 313.501210653753));
            temPoints.Add(new Point(457.13590757069, 319.699757869249));
            temPoints.Add(new Point(456.35755548799, 325.849878934625));
            temPoints.Add(new Point(455.481909394953, 331.806295399516));
            temPoints.Add(new Point(454.654910307084, 337.714285714286));
            temPoints.Add(new Point(453.730617208878, 343.525423728814));
            temPoints.Add(new Point(452.806324110672, 349.336561743341));
            temPoints.Add(new Point(451.833384007297, 355.050847457627));
            temPoints.Add(new Point(450.95773791426, 360.61985472155));
            temPoints.Add(new Point(449.936150805716, 365.995157384988));
            temPoints.Add(new Point(448.914563697172, 371.273607748184));
            temPoints.Add(new Point(447.941623593797, 376.503631961259));
            temPoints.Add(new Point(446.871389480085, 381.733656174334));
            temPoints.Add(new Point(445.849802371542, 386.915254237288));
            temPoints.Add(new Point(444.828215262998, 391.806295399516));
            temPoints.Add(new Point(443.806628154454, 396.600484261501));
            temPoints.Add(new Point(442.590453025236, 400.861985472155));
            temPoints.Add(new Point(441.958041958042, 405.414043583535));
            temPoints.Add(new Point(440.644572818486, 408.997578692494));
            temPoints.Add(new Point(439.866220735786, 412.43583535109));
            temPoints.Add(new Point(438.795986622074, 414.808716707022));
            strokes.Add(temPoints);
            count4++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);

            #endregion
            #region 5

            name = "5";
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(593.298875038005, 168.658595641646));
            temPoints.Add(new Point(593.88263910003, 168.513317191283));
            temPoints.Add(new Point(593.88263910003, 168.513317191283));
            temPoints.Add(new Point(593.88263910003, 168.513317191283));
            temPoints.Add(new Point(593.88263910003, 168.513317191283));
            temPoints.Add(new Point(594.125874125874, 168.077481840194));
            temPoints.Add(new Point(594.125874125874, 168.077481840194));
            temPoints.Add(new Point(594.125874125874, 168.077481840194));
            temPoints.Add(new Point(593.396169048343, 168.319612590799));
            temPoints.Add(new Point(592.569169960474, 168.271186440678));
            temPoints.Add(new Point(591.790817877774, 168.513317191283));
            temPoints.Add(new Point(590.477348738218, 168.561743341404));
            temPoints.Add(new Point(589.115232593493, 168.900726392252));
            temPoints.Add(new Point(587.266646397081, 169.142857142857));
            temPoints.Add(new Point(585.174825174825, 169.530266343826));
            temPoints.Add(new Point(582.64518090605, 170.062953995157));
            temPoints.Add(new Point(579.920948616601, 170.64406779661));
            temPoints.Add(new Point(576.710246275464, 171.273607748184));
            temPoints.Add(new Point(573.304955913652, 172.096852300242));
            temPoints.Add(new Point(569.413195500152, 172.871670702179));
            temPoints.Add(new Point(565.326847065978, 173.8401937046));
            temPoints.Add(new Point(560.899969595622, 174.760290556901));
            temPoints.Add(new Point(556.473092125266, 175.825665859564));
            temPoints.Add(new Point(551.802979629067, 176.648910411622));
            temPoints.Add(new Point(547.181514138036, 177.714285714286));
            temPoints.Add(new Point(542.511401641836, 178.585956416465));
            temPoints.Add(new Point(537.841289145637, 179.457627118644));
            temPoints.Add(new Point(533.268470659775, 180.280871670702));
            temPoints.Add(new Point(528.79294618425, 181.055690072639));
            temPoints.Add(new Point(524.463362724232, 181.733656174334));
            temPoints.Add(new Point(520.27972027972, 182.411622276029));
            temPoints.Add(new Point(516.290665855883, 182.944309927361));
            temPoints.Add(new Point(512.54484645789, 183.525423728814));
            temPoints.Add(new Point(508.944968075403, 183.961259079903));
            temPoints.Add(new Point(505.831559744603, 184.493946731235));
            temPoints.Add(new Point(502.912739434479, 184.978208232446));
            temPoints.Add(new Point(500.431742170873, 185.462469733656));
            temPoints.Add(new Point(498.242626938279, 185.946731234867));
            temPoints.Add(new Point(496.491334752204, 186.479418886199));
            temPoints.Add(new Point(495.080571602311, 187.01210653753));
            temPoints.Add(new Point(494.010337488598, 187.593220338983));
            temPoints.Add(new Point(493.329279416236, 188.222760290557));
            temPoints.Add(new Point(492.940103374886, 188.949152542373));
            temPoints.Add(new Point(492.891456369717, 189.627118644068));
            temPoints.Add(new Point(493.134691395561, 190.498789346247));
            temPoints.Add(new Point(493.57251444208, 191.370460048426));
            temPoints.Add(new Point(494.253572514442, 192.43583535109));
            temPoints.Add(new Point(494.983277591973, 193.549636803874));
            temPoints.Add(new Point(495.907570690179, 194.857142857143));
            temPoints.Add(new Point(496.783216783217, 196.213075060533));
            temPoints.Add(new Point(497.707509881423, 197.714285714286));
            temPoints.Add(new Point(498.534508969292, 199.457627118644));
            temPoints.Add(new Point(499.410155062329, 201.394673123487));
            temPoints.Add(new Point(500.188507145029, 203.476997578692));
            temPoints.Add(new Point(500.91821222256, 205.753026634383));
            temPoints.Add(new Point(501.599270294922, 208.222760290557));
            temPoints.Add(new Point(502.183034356947, 210.886198547215));
            temPoints.Add(new Point(502.718151413804, 213.791767554479));
            temPoints.Add(new Point(503.204621465491, 216.842615012107));
            temPoints.Add(new Point(503.593797506841, 219.893462469734));
            temPoints.Add(new Point(503.885679537853, 223.089588377724));
            temPoints.Add(new Point(504.177561568866, 226.334140435835));
            temPoints.Add(new Point(504.372149589541, 229.675544794189));
            temPoints.Add(new Point(504.518090605047, 233.065375302663));
            temPoints.Add(new Point(504.615384615385, 236.358353510896));
            temPoints.Add(new Point(504.615384615385, 239.699757869249));
            temPoints.Add(new Point(504.615384615385, 243.089588377724));
            temPoints.Add(new Point(504.566737610216, 246.382566585956));
            temPoints.Add(new Point(504.566737610216, 249.627118644068));
            temPoints.Add(new Point(504.469443599878, 252.677966101695));
            temPoints.Add(new Point(504.469443599878, 255.583535108959));
            temPoints.Add(new Point(504.42079659471, 258.246973365617));
            temPoints.Add(new Point(504.469443599878, 260.668280871671));
            temPoints.Add(new Point(504.518090605047, 262.653753026634));
            temPoints.Add(new Point(504.712678625722, 264.300242130751));
            temPoints.Add(new Point(504.858619641228, 265.607748184019));
            temPoints.Add(new Point(505.053207661903, 266.624697336562));
            temPoints.Add(new Point(505.247795682578, 267.351089588378));
            temPoints.Add(new Point(505.491030708422, 267.786924939467));
            temPoints.Add(new Point(505.491030708422, 267.786924939467));
            temPoints.Add(new Point(506.172088780784, 267.883777239709));
            temPoints.Add(new Point(506.609911827303, 267.593220338983));
            temPoints.Add(new Point(507.047734873822, 267.108958837772));
            temPoints.Add(new Point(507.680145941016, 266.382566585956));
            temPoints.Add(new Point(508.361204013378, 265.414043583535));
            temPoints.Add(new Point(509.334144116753, 264.25181598063));
            temPoints.Add(new Point(510.404378230465, 262.847457627119));
            temPoints.Add(new Point(511.717847370021, 261.249394673124));
            temPoints.Add(new Point(513.371845545759, 259.409200968523));
            temPoints.Add(new Point(515.415019762846, 257.375302663438));
            temPoints.Add(new Point(517.847370021283, 255.244552058111));
            temPoints.Add(new Point(520.766190331408, 252.9200968523));
            temPoints.Add(new Point(524.025539677714, 250.498789346247));
            temPoints.Add(new Point(527.722712070538, 248.029055690073));
            temPoints.Add(new Point(531.663119489206, 245.559322033898));
            temPoints.Add(new Point(535.992702949225, 243.186440677966));
            temPoints.Add(new Point(540.614168440255, 240.910411622276));
            temPoints.Add(new Point(545.430221951961, 238.82808716707));
            temPoints.Add(new Point(550.392216479173, 236.939467312349));
            temPoints.Add(new Point(555.500152021891, 235.341404358353));
            temPoints.Add(new Point(560.705381574947, 233.985472154964));
            temPoints.Add(new Point(565.959258133171, 232.9200968523));
            temPoints.Add(new Point(571.359075706902, 232.145278450363));
            temPoints.Add(new Point(576.758893280632, 231.757869249395));
            temPoints.Add(new Point(582.158710854363, 231.661016949153));
            temPoints.Add(new Point(587.461234417756, 231.951573849879));
            temPoints.Add(new Point(592.666463970812, 232.581113801453));
            temPoints.Add(new Point(597.77439951353, 233.549636803874));
            temPoints.Add(new Point(602.736394040742, 235.002421307506));
            temPoints.Add(new Point(607.552447552448, 236.939467312349));
            temPoints.Add(new Point(612.076619033141, 239.360774818402));
            temPoints.Add(new Point(616.308908482821, 242.266343825666));
            temPoints.Add(new Point(620.24931590149, 245.559322033898));
            temPoints.Add(new Point(623.800547278808, 249.28813559322));
            temPoints.Add(new Point(627.011249619945, 253.307506053269));
            temPoints.Add(new Point(629.735481909395, 257.665859564165));
            temPoints.Add(new Point(632.021891152326, 262.314769975787));
            temPoints.Add(new Point(633.773183338401, 267.254237288136));
            temPoints.Add(new Point(635.135299483126, 272.242130750605));
            temPoints.Add(new Point(635.865004560657, 277.230024213075));
            temPoints.Add(new Point(636.1082395865, 282.217917675545));
            temPoints.Add(new Point(635.767710550319, 287.205811138015));
            temPoints.Add(new Point(634.697476436607, 292.193704600484));
            temPoints.Add(new Point(633.092125266038, 297.278450363196));
            temPoints.Add(new Point(630.854363028276, 302.363196125908));
            temPoints.Add(new Point(627.935542718151, 307.254237288136));
            temPoints.Add(new Point(624.384311340833, 312.096852300242));
            temPoints.Add(new Point(620.152021891152, 316.794188861985));
            temPoints.Add(new Point(615.141380358772, 321.394673123487));
            temPoints.Add(new Point(609.352386743691, 325.801452784504));
            temPoints.Add(new Point(602.930982061417, 330.062953995157));
            temPoints.Add(new Point(595.682578291274, 333.985472154964));
            temPoints.Add(new Point(587.899057464275, 337.569007263923));
            temPoints.Add(new Point(579.58041958042, 340.813559322034));
            temPoints.Add(new Point(570.823958650046, 343.670702179177));
            temPoints.Add(new Point(561.629674673153, 346.188861985472));
            temPoints.Add(new Point(552.192155670416, 348.319612590799));
            temPoints.Add(new Point(542.851930678018, 350.014527845036));
            temPoints.Add(new Point(533.657646701125, 351.273607748184));
            temPoints.Add(new Point(524.901185770751, 352.145278450363));
            temPoints.Add(new Point(516.485253876558, 352.581113801453));
            temPoints.Add(new Point(508.896321070234, 352.774818401937));
            temPoints.Add(new Point(501.939799331104, 352.43583535109));
            temPoints.Add(new Point(496.442687747036, 352.193704600484));
            temPoints.Add(new Point(491.432046214655, 351.273607748184));
            temPoints.Add(new Point(487.783520826999, 350.1598062954));
            temPoints.Add(new Point(484.913347522043, 348.271186440678));
            strokes.Add(temPoints);
            count5++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(603.709334144117, 171.0799031477));
            temPoints.Add(new Point(603.709334144117, 171.0799031477));
            temPoints.Add(new Point(604.584980237154, 170.740920096852));
            temPoints.Add(new Point(604.584980237154, 170.740920096852));
            temPoints.Add(new Point(604.439039221648, 169.966101694915));
            temPoints.Add(new Point(604.439039221648, 169.966101694915));
            temPoints.Add(new Point(603.903922164792, 169.675544794189));
            temPoints.Add(new Point(603.417452113104, 169.675544794189));
            temPoints.Add(new Point(602.444512009729, 169.481840193705));
            temPoints.Add(new Point(601.374277896017, 169.433414043584));
            temPoints.Add(new Point(599.768926725448, 169.191283292978));
            temPoints.Add(new Point(598.212222560049, 169.142857142857));
            temPoints.Add(new Point(596.071754332624, 168.900726392252));
            temPoints.Add(new Point(593.88263910003, 168.949152542373));
            temPoints.Add(new Point(591.207053815749, 168.852300242131));
            temPoints.Add(new Point(588.336880510794, 168.997578692494));
            temPoints.Add(new Point(585.077531164488, 169.142857142857));
            temPoints.Add(new Point(581.477652782001, 169.384987893462));
            temPoints.Add(new Point(577.63453937367, 169.820823244552));
            temPoints.Add(new Point(573.499543934327, 170.305084745763));
            temPoints.Add(new Point(569.072666463971, 171.031476997579));
            temPoints.Add(new Point(564.548494983278, 171.854721549637));
            temPoints.Add(new Point(559.878382487078, 172.726392251816));
            temPoints.Add(new Point(555.15962298571, 173.646489104116));
            temPoints.Add(new Point(550.440863484342, 174.615012106538));
            temPoints.Add(new Point(545.819397993311, 175.583535108959));
            temPoints.Add(new Point(541.246579507449, 176.503631961259));
            temPoints.Add(new Point(536.819702037093, 177.47215496368));
            temPoints.Add(new Point(532.587412587413, 178.246973365617));
            temPoints.Add(new Point(528.549711158407, 179.021791767554));
            temPoints.Add(new Point(524.706597750076, 179.74818401937));
            temPoints.Add(new Point(521.106719367589, 180.571428571429));
            temPoints.Add(new Point(517.798723016114, 181.346246973366));
            temPoints.Add(new Point(514.782608695652, 182.121065375303));
            temPoints.Add(new Point(512.009729401034, 182.944309927361));
            temPoints.Add(new Point(509.626026147765, 183.767554479419));
            temPoints.Add(new Point(507.534204925509, 184.639225181598));
            temPoints.Add(new Point(505.734265734266, 185.65617433414));
            temPoints.Add(new Point(504.226208574035, 186.673123486683));
            temPoints.Add(new Point(502.961386439647, 187.835351089588));
            temPoints.Add(new Point(501.891152325935, 189.046004842615));
            temPoints.Add(new Point(501.015506232898, 190.450363196126));
            temPoints.Add(new Point(500.431742170873, 191.951573849879));
            temPoints.Add(new Point(499.993919124354, 193.646489104116));
            temPoints.Add(new Point(499.702037093341, 195.438256658596));
            temPoints.Add(new Point(499.604743083004, 197.423728813559));
            temPoints.Add(new Point(499.604743083004, 199.554479418886));
            temPoints.Add(new Point(499.799331103679, 201.830508474576));
            temPoints.Add(new Point(499.993919124354, 204.25181598063));
            temPoints.Add(new Point(500.383095165704, 206.915254237288));
            temPoints.Add(new Point(500.723624201885, 209.772397094431));
            temPoints.Add(new Point(501.161447248404, 212.871670702179));
            temPoints.Add(new Point(501.599270294922, 216.164648910412));
            temPoints.Add(new Point(502.037093341441, 219.554479418886));
            temPoints.Add(new Point(502.426269382791, 223.138014527845));
            temPoints.Add(new Point(502.766798418972, 226.818401937046));
            temPoints.Add(new Point(503.010033444816, 230.64406779661));
            temPoints.Add(new Point(503.155974460322, 234.566585956416));
            temPoints.Add(new Point(503.204621465491, 238.585956416465));
            temPoints.Add(new Point(503.25326847066, 242.653753026634));
            temPoints.Add(new Point(503.204621465491, 246.721549636804));
            temPoints.Add(new Point(503.107327455154, 250.837772397094));
            temPoints.Add(new Point(502.961386439647, 254.760290556901));
            temPoints.Add(new Point(502.912739434479, 258.682808716707));
            temPoints.Add(new Point(502.86409242931, 262.508474576271));
            temPoints.Add(new Point(502.86409242931, 266.237288135593));
            temPoints.Add(new Point(502.86409242931, 269.72397094431));
            temPoints.Add(new Point(502.86409242931, 273.113801452785));
            temPoints.Add(new Point(502.912739434479, 276.358353510896));
            temPoints.Add(new Point(503.010033444816, 279.457627118644));
            temPoints.Add(new Point(503.107327455154, 282.411622276029));
            temPoints.Add(new Point(503.25326847066, 285.220338983051));
            temPoints.Add(new Point(503.399209486166, 287.835351089588));
            temPoints.Add(new Point(503.64244451201, 290.305084745763));
            temPoints.Add(new Point(503.934326543022, 292.581113801453));
            temPoints.Add(new Point(504.323502584372, 294.518159806295));
            temPoints.Add(new Point(504.80997263606, 296.261501210654));
            temPoints.Add(new Point(505.296442687747, 297.762711864407));
            temPoints.Add(new Point(505.831559744603, 299.021791767554));
            temPoints.Add(new Point(506.463970811797, 300.038740920097));
            temPoints.Add(new Point(507.145028884159, 300.861985472155));
            temPoints.Add(new Point(507.923380966859, 301.443099273608));
            temPoints.Add(new Point(508.750380054728, 301.733656174334));
            temPoints.Add(new Point(509.723320158103, 301.830508474576));
            temPoints.Add(new Point(510.842201276984, 301.733656174334));
            temPoints.Add(new Point(512.15567041654, 301.394673123487));
            temPoints.Add(new Point(513.566433566433, 300.861985472155));
            temPoints.Add(new Point(515.220431742171, 300.087167070218));
            temPoints.Add(new Point(517.020370933414, 299.118644067797));
            temPoints.Add(new Point(518.966251140164, 297.956416464891));
            temPoints.Add(new Point(521.204013377926, 296.697336561743));
            temPoints.Add(new Point(523.539069626026, 295.292978208232));
            temPoints.Add(new Point(526.020066889632, 293.791767554479));
            temPoints.Add(new Point(528.647005168744, 292.193704600484));
            temPoints.Add(new Point(531.419884463363, 290.595641646489));
            temPoints.Add(new Point(534.290057768319, 288.900726392252));
            temPoints.Add(new Point(537.257525083612, 287.205811138015));
            temPoints.Add(new Point(540.370933414412, 285.559322033898));
            temPoints.Add(new Point(543.581635755549, 283.961259079903));
            temPoints.Add(new Point(546.889632107023, 282.46004842615));
            temPoints.Add(new Point(550.440863484342, 280.958837772397));
            temPoints.Add(new Point(554.040741866829, 279.602905569007));
            temPoints.Add(new Point(557.786561264822, 278.34382566586));
            temPoints.Add(new Point(561.678321678322, 277.230024213075));
            temPoints.Add(new Point(565.667376102159, 276.261501210654));
            temPoints.Add(new Point(569.851018546671, 275.486682808717));
            temPoints.Add(new Point(574.13195500152, 274.760290556901));
            temPoints.Add(new Point(578.461538461538, 274.227602905569));
            temPoints.Add(new Point(582.888415931894, 273.937046004843));
            temPoints.Add(new Point(587.266646397081, 273.791767554479));
            temPoints.Add(new Point(591.742170872606, 273.8401937046));
            temPoints.Add(new Point(596.266342353299, 274.082324455206));
            temPoints.Add(new Point(600.644572818486, 274.615012106538));
            temPoints.Add(new Point(604.974156278504, 275.341404358353));
            temPoints.Add(new Point(609.109151717847, 276.406779661017));
            temPoints.Add(new Point(613.049559136516, 277.762711864407));
            temPoints.Add(new Point(616.795378534509, 279.409200968523));
            temPoints.Add(new Point(620.297962906659, 281.297820823245));
            temPoints.Add(new Point(623.508665247796, 283.428571428571));
            temPoints.Add(new Point(626.378838552752, 285.801452784504));
            temPoints.Add(new Point(628.957129826695, 288.416464891041));
            temPoints.Add(new Point(631.09759805412, 291.273607748184));
            temPoints.Add(new Point(632.897537245363, 294.27602905569));
            temPoints.Add(new Point(634.356947400426, 297.520581113801));
            temPoints.Add(new Point(635.427181514138, 301.055690072639));
            temPoints.Add(new Point(636.1082395865, 304.929782082324));
            temPoints.Add(new Point(636.400121617513, 308.949152542373));
            temPoints.Add(new Point(636.448768622682, 313.210653753027));
            temPoints.Add(new Point(636.010945576163, 317.617433414044));
            temPoints.Add(new Point(635.135299483126, 322.217917675545));
            temPoints.Add(new Point(633.919124353907, 326.963680387409));
            temPoints.Add(new Point(632.411067193676, 331.951573849879));
            temPoints.Add(new Point(630.416539981757, 336.842615012107));
            temPoints.Add(new Point(628.130130738826, 341.782082324455));
            temPoints.Add(new Point(625.357251444208, 346.624697336562));
            temPoints.Add(new Point(622.243843113408, 351.467312348668));
            temPoints.Add(new Point(618.838552751596, 356.261501210654));
            temPoints.Add(new Point(615.335968379447, 361.10411622276));
            temPoints.Add(new Point(611.492854971116, 365.753026634383));
            temPoints.Add(new Point(607.406506536941, 370.1598062954));
            temPoints.Add(new Point(603.028276071754, 374.372881355932));
            temPoints.Add(new Point(598.406810580724, 378.392251815981));
            temPoints.Add(new Point(593.396169048343, 382.169491525424));
            temPoints.Add(new Point(588.044998479781, 385.65617433414));
            temPoints.Add(new Point(582.110063849194, 388.755447941889));
            temPoints.Add(new Point(575.494071146245, 391.418886198547));
            temPoints.Add(new Point(568.197020370933, 393.598062953995));
            temPoints.Add(new Point(559.975676497416, 395.438256658596));
            temPoints.Add(new Point(550.927333536029, 396.98789346247));
            temPoints.Add(new Point(541.343873517787, 398.246973365617));
            temPoints.Add(new Point(531.663119489206, 399.26392251816));
            temPoints.Add(new Point(522.031012465795, 400.18401937046));
            temPoints.Add(new Point(512.788081483734, 400.910411622276));
            temPoints.Add(new Point(504.128914563697, 401.346246973366));
            temPoints.Add(new Point(496.685922772879, 401.927360774818));
            temPoints.Add(new Point(489.826695044086, 401.975786924939));
            temPoints.Add(new Point(484.767406506537, 402.072639225182));
            temPoints.Add(new Point(480.486470051687, 401.443099273608));
            temPoints.Add(new Point(477.373061720888, 400.61985472155));
            strokes.Add(temPoints);
            count5++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);

            #endregion
            #region 6

            name = "6";
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(525.144420796595, 147.254237288136));
            temPoints.Add(new Point(525.144420796595, 147.254237288136));
            temPoints.Add(new Point(525.144420796595, 147.254237288136));
            temPoints.Add(new Point(524.512009729401, 147.108958837772));
            temPoints.Add(new Point(524.074186682882, 146.866828087167));
            temPoints.Add(new Point(524.074186682882, 146.866828087167));
            temPoints.Add(new Point(523.149893584676, 146.52784503632));
            temPoints.Add(new Point(522.61477652782, 146.479418886199));
            temPoints.Add(new Point(521.739130434783, 146.237288135593));
            temPoints.Add(new Point(520.912131346914, 146.237288135593));
            temPoints.Add(new Point(519.695956217695, 146.09200968523));
            temPoints.Add(new Point(518.479781088477, 146.285714285714));
            temPoints.Add(new Point(516.923076923077, 146.576271186441));
            temPoints.Add(new Point(515.366372757677, 147.157384987893));
            temPoints.Add(new Point(513.420492550927, 147.883777239709));
            temPoints.Add(new Point(511.280024323503, 148.949152542373));
            temPoints.Add(new Point(508.847674065065, 150.1598062954));
            temPoints.Add(new Point(506.220735785953, 151.709443099274));
            temPoints.Add(new Point(503.301915475828, 153.501210653753));
            temPoints.Add(new Point(500.334448160535, 155.63196125908));
            temPoints.Add(new Point(497.123745819398, 158.004842615012));
            temPoints.Add(new Point(493.815749467923, 160.765133171913));
            temPoints.Add(new Point(490.167224080268, 163.573849878935));
            temPoints.Add(new Point(486.664639708118, 166.673123486683));
            temPoints.Add(new Point(482.918820310125, 169.917675544794));
            temPoints.Add(new Point(479.416235937975, 173.452784503632));
            temPoints.Add(new Point(475.816357555488, 176.939467312349));
            temPoints.Add(new Point(472.411067193676, 180.668280871671));
            temPoints.Add(new Point(469.005776831864, 184.397094430993));
            temPoints.Add(new Point(465.941015506233, 188.319612590799));
            temPoints.Add(new Point(462.924901185771, 192.242130750605));
            temPoints.Add(new Point(460.103374885984, 196.309927360775));
            temPoints.Add(new Point(457.281848586196, 200.329297820823));
            temPoints.Add(new Point(454.654910307084, 204.493946731235));
            temPoints.Add(new Point(452.173913043478, 208.658595641646));
            temPoints.Add(new Point(449.838856795378, 213.016949152542));
            temPoints.Add(new Point(447.601094557616, 217.375302663438));
            temPoints.Add(new Point(445.606567345698, 221.878934624697));
            temPoints.Add(new Point(443.709334144117, 226.334140435835));
            temPoints.Add(new Point(442.103982973548, 230.934624697337));
            temPoints.Add(new Point(440.644572818486, 235.438256658596));
            temPoints.Add(new Point(439.379750684099, 240.18401937046));
            temPoints.Add(new Point(438.16357555488, 244.881355932203));
            temPoints.Add(new Point(437.190635451505, 249.530266343826));
            temPoints.Add(new Point(436.363636363636, 253.937046004843));
            temPoints.Add(new Point(435.633931286105, 258.198547215496));
            temPoints.Add(new Point(435.05016722408, 262.314769975787));
            temPoints.Add(new Point(434.612344177562, 266.382566585956));
            temPoints.Add(new Point(434.417756156887, 270.208232445521));
            temPoints.Add(new Point(434.417756156887, 273.888619854722));
            temPoints.Add(new Point(434.563697172393, 277.278450363196));
            temPoints.Add(new Point(434.952873213743, 280.61985472155));
            temPoints.Add(new Point(435.487990270599, 283.81598062954));
            temPoints.Add(new Point(436.363636363636, 286.963680387409));
            temPoints.Add(new Point(437.336576467011, 289.869249394673));
            temPoints.Add(new Point(438.650045606567, 292.677966101695));
            temPoints.Add(new Point(440.060808756461, 295.19612590799));
            temPoints.Add(new Point(441.714806932198, 297.520581113801));
            temPoints.Add(new Point(443.660687138948, 299.651331719128));
            temPoints.Add(new Point(445.801155366373, 301.491525423729));
            temPoints.Add(new Point(448.136211614472, 303.041162227603));
            temPoints.Add(new Point(450.665855883247, 304.397094430993));
            temPoints.Add(new Point(453.292794162359, 305.462469733656));
            temPoints.Add(new Point(456.065673456978, 306.430992736077));
            temPoints.Add(new Point(458.935846761934, 307.205811138015));
            temPoints.Add(new Point(461.854667072058, 307.883777239709));
            temPoints.Add(new Point(464.724840377014, 308.319612590799));
            temPoints.Add(new Point(467.692307692308, 308.561743341404));
            temPoints.Add(new Point(470.70842201277, 308.707021791768));
            temPoints.Add(new Point(473.773183338401, 308.658595641646));
            temPoints.Add(new Point(476.8865916692, 308.464891041162));
            temPoints.Add(new Point(479.951352994831, 308.125907990315));
            temPoints.Add(new Point(482.967467315293, 307.641646489104));
            temPoints.Add(new Point(486.032228640924, 307.01210653753));
            temPoints.Add(new Point(488.951048951049, 306.188861985472));
            temPoints.Add(new Point(491.772575250836, 305.268765133172));
            temPoints.Add(new Point(494.399513529948, 304.25181598063));
            temPoints.Add(new Point(496.929157798723, 303.089588377724));
            temPoints.Add(new Point(499.215567041654, 301.782082324455));
            temPoints.Add(new Point(501.453329279416, 300.377723970944));
            temPoints.Add(new Point(503.447856491335, 298.779661016949));
            temPoints.Add(new Point(505.296442687747, 297.084745762712));
            temPoints.Add(new Point(506.999087868653, 295.244552058111));
            temPoints.Add(new Point(508.555792034053, 293.307506053269));
            temPoints.Add(new Point(509.966555183946, 291.322033898305));
            temPoints.Add(new Point(511.182730313165, 289.191283292978));
            temPoints.Add(new Point(512.15567041654, 287.060532687651));
            temPoints.Add(new Point(512.982669504409, 284.929782082324));
            temPoints.Add(new Point(513.615080571602, 282.847457627119));
            temPoints.Add(new Point(513.955609607783, 280.765133171913));
            temPoints.Add(new Point(514.150197628459, 278.682808716707));
            temPoints.Add(new Point(514.198844633627, 276.600484261501));
            temPoints.Add(new Point(514.052903618121, 274.469733656174));
            temPoints.Add(new Point(513.761021587109, 272.338983050847));
            temPoints.Add(new Point(513.371845545759, 270.111380145278));
            temPoints.Add(new Point(512.836728488902, 267.786924939467));
            temPoints.Add(new Point(512.204317421709, 265.268765133172));
            temPoints.Add(new Point(511.523259349346, 262.750605326877));
            temPoints.Add(new Point(510.793554271815, 260.280871670702));
            temPoints.Add(new Point(509.917908178778, 257.714285714286));
            temPoints.Add(new Point(508.944968075403, 255.19612590799));
            temPoints.Add(new Point(508.020674977197, 252.726392251816));
            temPoints.Add(new Point(506.950440863484, 250.305084745763));
            temPoints.Add(new Point(505.928853754941, 247.980629539952));
            temPoints.Add(new Point(504.907266646397, 245.849878934625));
            temPoints.Add(new Point(503.739738522347, 243.719128329298));
            temPoints.Add(new Point(502.523563393129, 241.636803874092));
            temPoints.Add(new Point(501.210094253572, 239.602905569007));
            temPoints.Add(new Point(499.75068409851, 237.617433414044));
            temPoints.Add(new Point(498.145332927942, 235.63196125908));
            temPoints.Add(new Point(496.345393736698, 233.646489104116));
            temPoints.Add(new Point(494.399513529948, 231.709443099274));
            temPoints.Add(new Point(492.210398297355, 229.917675544794));
            temPoints.Add(new Point(489.923989054424, 228.125907990315));
            temPoints.Add(new Point(487.491638795987, 226.430992736077));
            temPoints.Add(new Point(485.010641532381, 224.784503631961));
            temPoints.Add(new Point(482.529644268775, 223.283292978208));
            temPoints.Add(new Point(480, 221.878934624697));
            temPoints.Add(new Point(477.519002736394, 220.668280871671));
            temPoints.Add(new Point(474.940711462451, 219.506053268765));
            temPoints.Add(new Point(472.411067193676, 218.392251815981));
            temPoints.Add(new Point(469.881422924901, 217.423728813559));
            temPoints.Add(new Point(467.400425661295, 216.55205811138));
            temPoints.Add(new Point(464.919428397689, 215.825665859564));
            temPoints.Add(new Point(462.487078139252, 215.050847457627));
            temPoints.Add(new Point(460.200668896321, 214.372881355932));
            temPoints.Add(new Point(457.962906658559, 213.791767554479));
            temPoints.Add(new Point(455.822438431134, 213.259079903148));
            temPoints.Add(new Point(453.827911219216, 212.774818401937));
            temPoints.Add(new Point(452.027972027972, 212.338983050847));
            temPoints.Add(new Point(450.276679841897, 212));
            temPoints.Add(new Point(448.671328671329, 211.661016949153));
            temPoints.Add(new Point(447.309212526604, 211.612590799031));
            temPoints.Add(new Point(445.995743387048, 211.370460048426));
            temPoints.Add(new Point(445.314685314685, 211.757869249395));
            temPoints.Add(new Point(444.390392216479, 211.903147699758));
            temPoints.Add(new Point(443.95256916996, 212.145278450363));
            temPoints.Add(new Point(443.466099118273, 211.951573849879));
            strokes.Add(temPoints);
            count6++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(557.10550319246, 180.087167070218));
            temPoints.Add(new Point(557.10550319246, 180.087167070218));
            temPoints.Add(new Point(556.521739130435, 179.845036319613));
            temPoints.Add(new Point(556.521739130435, 179.845036319613));
            temPoints.Add(new Point(556.035269078747, 179.506053268765));
            temPoints.Add(new Point(556.035269078747, 179.506053268765));
            temPoints.Add(new Point(555.451505016722, 179.118644067797));
            temPoints.Add(new Point(554.77044694436, 178.779661016949));
            temPoints.Add(new Point(554.138035877166, 178.731234866828));
            temPoints.Add(new Point(553.067801763454, 178.392251815981));
            temPoints.Add(new Point(552.04621465491, 178.392251815981));
            temPoints.Add(new Point(550.538157494679, 178.101694915254));
            temPoints.Add(new Point(549.030100334448, 178.198547215496));
            temPoints.Add(new Point(547.03557312253, 178.34382566586));
            temPoints.Add(new Point(544.895104895105, 178.634382566586));
            temPoints.Add(new Point(542.608695652174, 179.118644067797));
            temPoints.Add(new Point(540.127698388568, 179.796610169492));
            temPoints.Add(new Point(537.452113104287, 180.61985472155));
            temPoints.Add(new Point(534.581939799331, 181.588377723971));
            temPoints.Add(new Point(531.468531468531, 182.750605326876));
            temPoints.Add(new Point(528.257829127394, 184.154963680387));
            temPoints.Add(new Point(524.803891760413, 185.753026634383));
            temPoints.Add(new Point(521.252660383095, 187.690072639225));
            temPoints.Add(new Point(517.506840985102, 189.869249394673));
            temPoints.Add(new Point(513.663727576771, 192.290556900726));
            temPoints.Add(new Point(509.674673152934, 194.953995157385));
            temPoints.Add(new Point(505.636971723928, 197.859564164649));
            temPoints.Add(new Point(501.501976284585, 201.055690072639));
            temPoints.Add(new Point(497.366980845242, 204.445520581114));
            temPoints.Add(new Point(493.037397385223, 207.93220338983));
            temPoints.Add(new Point(488.805107935543, 211.661016949153));
            temPoints.Add(new Point(484.524171480693, 215.63196125908));
            temPoints.Add(new Point(480.145941015506, 219.893462469734));
            temPoints.Add(new Point(475.767710550319, 224.348668280872));
            temPoints.Add(new Point(471.438127090301, 229.046004842615));
            temPoints.Add(new Point(467.059896625114, 234.033898305085));
            temPoints.Add(new Point(462.681666159927, 239.312348668281));
            temPoints.Add(new Point(458.546670720584, 244.832929782082));
            temPoints.Add(new Point(454.606263301915, 250.450363196126));
            temPoints.Add(new Point(450.860443903922, 255.922518159806));
            temPoints.Add(new Point(447.45515354211, 261.491525423729));
            temPoints.Add(new Point(444.293098206142, 266.963680387409));
            temPoints.Add(new Point(441.471571906354, 272.629539951574));
            temPoints.Add(new Point(438.94192763758, 278.150121065375));
            temPoints.Add(new Point(436.850106415324, 283.622276029056));
            temPoints.Add(new Point(435.001520218911, 288.852300242131));
            temPoints.Add(new Point(433.49346305868, 294.179176755448));
            temPoints.Add(new Point(432.228640924293, 299.409200968523));
            temPoints.Add(new Point(431.255700820918, 304.832929782082));
            temPoints.Add(new Point(430.42870173305, 310.1598062954));
            temPoints.Add(new Point(430.0395256917, 315.292978208232));
            temPoints.Add(new Point(429.747643660687, 320.18401937046));
            temPoints.Add(new Point(429.796290665856, 325.075060532688));
            temPoints.Add(new Point(429.942231681362, 329.675544794189));
            temPoints.Add(new Point(430.380054727881, 334.227602905569));
            temPoints.Add(new Point(431.061112800243, 338.489104116223));
            temPoints.Add(new Point(432.082699908787, 342.46004842615));
            temPoints.Add(new Point(433.298875038005, 346.140435835351));
            temPoints.Add(new Point(434.855579203405, 349.627118644068));
            temPoints.Add(new Point(436.752812404986, 352.677966101695));
            temPoints.Add(new Point(438.990574642749, 355.535108958838));
            temPoints.Add(new Point(441.568865916692, 358.053268765133));
            temPoints.Add(new Point(444.439039221648, 360.232445520581));
            temPoints.Add(new Point(447.552447552448, 362.072639225182));
            temPoints.Add(new Point(450.909090909091, 363.573849878935));
            temPoints.Add(new Point(454.460322286409, 364.881355932203));
            temPoints.Add(new Point(458.157494679234, 365.898305084746));
            temPoints.Add(new Point(461.951961082396, 366.721549636804));
            temPoints.Add(new Point(465.746427485558, 367.351089588378));
            temPoints.Add(new Point(469.638187899057, 367.738498789346));
            temPoints.Add(new Point(473.529948312557, 367.883777239709));
            temPoints.Add(new Point(477.373061720888, 367.786924939467));
            temPoints.Add(new Point(481.264822134387, 367.544794188862));
            temPoints.Add(new Point(485.010641532381, 366.963680387409));
            temPoints.Add(new Point(488.707813925205, 366.237288135593));
            temPoints.Add(new Point(492.307692307692, 365.317191283293));
            temPoints.Add(new Point(495.858923685011, 364.154963680387));
            temPoints.Add(new Point(499.166920036485, 362.799031476998));
            temPoints.Add(new Point(502.426269382791, 361.346246973366));
            temPoints.Add(new Point(505.539677713591, 359.602905569007));
            temPoints.Add(new Point(508.458498023715, 357.617433414044));
            temPoints.Add(new Point(511.280024323503, 355.438256658596));
            temPoints.Add(new Point(514.052903618121, 353.113801452785));
            temPoints.Add(new Point(516.679841897233, 350.64406779661));
            temPoints.Add(new Point(519.160839160839, 348.125907990315));
            temPoints.Add(new Point(521.44724840377, 345.462469733656));
            temPoints.Add(new Point(523.587716631195, 342.799031476998));
            temPoints.Add(new Point(525.484949832776, 340.087167070218));
            temPoints.Add(new Point(527.236242018851, 337.423728813559));
            temPoints.Add(new Point(528.79294618425, 334.663438256659));
            temPoints.Add(new Point(530.252356339313, 331.854721549637));
            temPoints.Add(new Point(531.371237458194, 328.852300242131));
            temPoints.Add(new Point(532.392824566738, 325.898305084746));
            temPoints.Add(new Point(533.219823654606, 322.89588377724));
            temPoints.Add(new Point(533.803587716631, 319.941888619855));
            temPoints.Add(new Point(534.24141076315, 317.036319612591));
            temPoints.Add(new Point(534.484645788994, 314.179176755448));
            temPoints.Add(new Point(534.484645788994, 311.467312348668));
            temPoints.Add(new Point(534.290057768319, 308.900726392252));
            temPoints.Add(new Point(533.949528732137, 306.576271186441));
            temPoints.Add(new Point(533.414411675281, 304.300242130751));
            temPoints.Add(new Point(532.733353602919, 302.024213075061));
            temPoints.Add(new Point(531.90635451505, 299.796610169492));
            temPoints.Add(new Point(530.982061416844, 297.520581113801));
            temPoints.Add(new Point(529.911827303132, 295.244552058111));
            temPoints.Add(new Point(528.744299179082, 292.9200968523));
            temPoints.Add(new Point(527.430830039526, 290.547215496368));
            temPoints.Add(new Point(525.971419884463, 288.125907990315));
            temPoints.Add(new Point(524.414715719064, 285.753026634383));
            temPoints.Add(new Point(522.663423532989, 283.38014527845));
            temPoints.Add(new Point(520.863484341745, 281.10411622276));
            temPoints.Add(new Point(519.014898145333, 278.82808716707));
            temPoints.Add(new Point(516.971723928246, 276.600484261501));
            temPoints.Add(new Point(514.928549711158, 274.469733656174));
            temPoints.Add(new Point(512.885375494071, 272.387409200969));
            temPoints.Add(new Point(510.793554271815, 270.353510895884));
            temPoints.Add(new Point(508.701733049559, 268.319612590799));
            temPoints.Add(new Point(506.609911827303, 266.237288135593));
            temPoints.Add(new Point(504.518090605047, 264.154963680387));
            temPoints.Add(new Point(502.426269382791, 262.217917675545));
            temPoints.Add(new Point(500.285801155366, 260.280871670702));
            temPoints.Add(new Point(498.145332927942, 258.392251815981));
            temPoints.Add(new Point(495.956217695348, 256.55205811138));
            temPoints.Add(new Point(493.718455457586, 254.857142857143));
            temPoints.Add(new Point(491.383399209486, 253.210653753027));
            temPoints.Add(new Point(488.951048951049, 251.757869249395));
            temPoints.Add(new Point(486.518698692612, 250.450363196126));
            temPoints.Add(new Point(483.8917604135, 249.191283292978));
            temPoints.Add(new Point(481.362116144725, 248.077481840194));
            temPoints.Add(new Point(478.783824870781, 247.108958837772));
            temPoints.Add(new Point(476.254180602007, 246.285714285714));
            temPoints.Add(new Point(473.870477348738, 245.607748184019));
            temPoints.Add(new Point(471.681362116145, 245.075060532688));
            temPoints.Add(new Point(469.638187899057, 244.639225181598));
            temPoints.Add(new Point(467.789601702645, 244.397094430993));
            temPoints.Add(new Point(466.184250532077, 244.25181598063));
            temPoints.Add(new Point(464.773487382183, 244.25181598063));
            temPoints.Add(new Point(463.557312252964, 244.445520581114));
            temPoints.Add(new Point(462.389784128915, 244.687651331719));
            temPoints.Add(new Point(461.368197020371, 245.075060532688));
            temPoints.Add(new Point(460.346609911827, 245.510895883777));
            temPoints.Add(new Point(459.519610823959, 246.09200968523));
            temPoints.Add(new Point(458.741258741259, 246.576271186441));
            temPoints.Add(new Point(458.30343569474, 247.302663438257));
            temPoints.Add(new Point(457.768318637884, 247.593220338983));
            temPoints.Add(new Point(457.91425965339, 248.222760290557));
            temPoints.Add(new Point(457.91425965339, 248.222760290557));
            temPoints.Add(new Point(458.838552751596, 248.80387409201));
            temPoints.Add(new Point(459.714198844634, 248.755447941889));
            strokes.Add(temPoints);
            count6++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);

            #endregion
            #region 7

            name = "7";
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(417.439951352995, 190.1598062954));
            temPoints.Add(new Point(417.439951352995, 190.1598062954));
            temPoints.Add(new Point(416.953481301307, 190.111380145278));
            temPoints.Add(new Point(416.953481301307, 190.111380145278));
            temPoints.Add(new Point(416.953481301307, 190.111380145278));
            temPoints.Add(new Point(416.953481301307, 190.111380145278));
            temPoints.Add(new Point(416.953481301307, 190.111380145278));
            temPoints.Add(new Point(416.953481301307, 190.111380145278));
            temPoints.Add(new Point(417.294010337489, 190.740920096852));
            temPoints.Add(new Point(417.780480389176, 190.934624697337));
            temPoints.Add(new Point(418.656126482213, 191.370460048426));
            temPoints.Add(new Point(419.726360595926, 191.612590799031));
            temPoints.Add(new Point(421.380358771663, 192.048426150121));
            temPoints.Add(new Point(423.180297962907, 192.338983050847));
            temPoints.Add(new Point(425.515354211006, 192.823244552058));
            temPoints.Add(new Point(428.09364548495, 193.113801452785));
            temPoints.Add(new Point(431.158406810581, 193.549636803874));
            temPoints.Add(new Point(434.369109151718, 194.082324455206));
            temPoints.Add(new Point(438.114928549711, 194.615012106538));
            temPoints.Add(new Point(441.958041958042, 195.19612590799));
            temPoints.Add(new Point(446.190331407723, 196.019370460048));
            temPoints.Add(new Point(450.519914867741, 196.745762711864));
            temPoints.Add(new Point(455.092733353603, 197.665859564165));
            temPoints.Add(new Point(459.714198844634, 198.585956416465));
            temPoints.Add(new Point(464.530252356339, 199.651331719128));
            temPoints.Add(new Point(469.394952873214, 200.474576271186));
            temPoints.Add(new Point(474.356947400426, 201.53995157385));
            temPoints.Add(new Point(479.124353906963, 202.363196125908));
            temPoints.Add(new Point(483.745819397993, 203.283292978208));
            temPoints.Add(new Point(488.221343873518, 204.154963680387));
            temPoints.Add(new Point(492.502280328367, 204.929782082324));
            temPoints.Add(new Point(496.442687747036, 205.704600484262));
            temPoints.Add(new Point(499.945272119185, 206.382566585956));
            temPoints.Add(new Point(502.961386439647, 207.108958837772));
            temPoints.Add(new Point(505.491030708422, 207.786924939467));
            temPoints.Add(new Point(507.582851930678, 208.464891041162));
            temPoints.Add(new Point(509.236850106415, 209.191283292978));
            temPoints.Add(new Point(510.355731225296, 209.917675544794));
            temPoints.Add(new Point(511.134083307996, 210.740920096852));
            temPoints.Add(new Point(511.425965339009, 211.612590799031));
            temPoints.Add(new Point(511.425965339009, 212.677966101695));
            temPoints.Add(new Point(510.98814229249, 213.743341404358));
            temPoints.Add(new Point(510.355731225296, 215.050847457627));
            temPoints.Add(new Point(509.236850106415, 216.455205811138));
            temPoints.Add(new Point(507.923380966859, 218.004842615012));
            temPoints.Add(new Point(506.172088780784, 219.602905569007));
            temPoints.Add(new Point(504.323502584372, 221.394673123487));
            temPoints.Add(new Point(502.134387351779, 223.38014527845));
            temPoints.Add(new Point(499.799331103679, 225.607748184019));
            temPoints.Add(new Point(497.172392824567, 227.980629539952));
            temPoints.Add(new Point(494.302219519611, 230.692493946731));
            temPoints.Add(new Point(491.334752204317, 233.598062953995));
            temPoints.Add(new Point(488.269990878686, 236.891041162228));
            temPoints.Add(new Point(485.156582547887, 240.329297820823));
            temPoints.Add(new Point(482.043174217087, 244.058111380145));
            temPoints.Add(new Point(478.735177865613, 247.835351089588));
            temPoints.Add(new Point(475.427181514138, 251.903147699758));
            temPoints.Add(new Point(472.021891152326, 256.067796610169));
            temPoints.Add(new Point(468.713894800851, 260.474576271186));
            temPoints.Add(new Point(465.114016418364, 264.978208232446));
            temPoints.Add(new Point(461.514138035877, 269.578692493947));
            temPoints.Add(new Point(457.719671632715, 274.227602905569));
            temPoints.Add(new Point(453.925205229553, 279.021791767554));
            temPoints.Add(new Point(450.033444816053, 283.719128329298));
            temPoints.Add(new Point(446.093037397385, 288.561743341404));
            temPoints.Add(new Point(442.006688963211, 293.35593220339));
            temPoints.Add(new Point(437.823046518699, 298.150121065375));
            temPoints.Add(new Point(433.590757069018, 302.702179176755));
            temPoints.Add(new Point(429.309820614168, 307.254237288136));
            temPoints.Add(new Point(425.077531164488, 311.56416464891));
            temPoints.Add(new Point(420.796594709638, 315.874092009685));
            temPoints.Add(new Point(416.661599270295, 319.990314769976));
            temPoints.Add(new Point(412.672544846458, 324.009685230024));
            temPoints.Add(new Point(408.926725448465, 327.738498789346));
            temPoints.Add(new Point(405.472788081484, 331.273607748184));
            temPoints.Add(new Point(402.310732745515, 334.518159806295));
            temPoints.Add(new Point(399.489206445728, 337.375302663438));
            temPoints.Add(new Point(397.056856187291, 339.990314769976));
            temPoints.Add(new Point(394.965034965035, 342.024213075061));
            temPoints.Add(new Point(393.797506840985, 343.961259079903));
            temPoints.Add(new Point(392.678625722104, 344.978208232446));
            temPoints.Add(new Point(392.289449680754, 345.414043583535));
            temPoints.Add(new Point(392.094861660079, 344.929782082324));
            strokes.Add(temPoints);
            count7++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(345.685618729097, 190.498789346247));
            temPoints.Add(new Point(345.685618729097, 190.498789346247));
            temPoints.Add(new Point(345.247795682578, 190.256658595642));
            temPoints.Add(new Point(345.247795682578, 190.256658595642));
            temPoints.Add(new Point(345.880206749772, 190.208232445521));
            temPoints.Add(new Point(346.463970811797, 190.208232445521));
            temPoints.Add(new Point(347.680145941016, 190.401937046005));
            temPoints.Add(new Point(349.090909090909, 190.450363196126));
            temPoints.Add(new Point(351.231377318334, 190.740920096852));
            temPoints.Add(new Point(353.761021587109, 190.886198547215));
            temPoints.Add(new Point(357.020370933414, 191.176755447942));
            temPoints.Add(new Point(360.717543326239, 191.370460048426));
            temPoints.Add(new Point(365.095773791426, 191.661016949153));
            temPoints.Add(new Point(370.009121313469, 191.854721549637));
            temPoints.Add(new Point(375.652173913043, 192.145278450363));
            temPoints.Add(new Point(381.635755548799, 192.290556900726));
            temPoints.Add(new Point(388.057160231073, 192.581113801453));
            temPoints.Add(new Point(394.721799939191, 192.774818401937));
            temPoints.Add(new Point(401.970203709334, 193.113801452785));
            temPoints.Add(new Point(409.267254484646, 193.404358353511));
            temPoints.Add(new Point(416.807540285801, 193.8401937046));
            temPoints.Add(new Point(424.250532076619, 194.421307506053));
            temPoints.Add(new Point(431.985405898449, 195.002421307506));
            temPoints.Add(new Point(439.525691699605, 195.680387409201));
            temPoints.Add(new Point(447.017330495591, 196.503631961259));
            temPoints.Add(new Point(454.217087260566, 197.278450363196));
            temPoints.Add(new Point(461.02766798419, 198.150121065375));
            temPoints.Add(new Point(467.497719671633, 198.924939467312));
            temPoints.Add(new Point(473.675889328063, 199.796610169492));
            temPoints.Add(new Point(479.367588932806, 200.523002421308));
            temPoints.Add(new Point(484.329583460018, 201.394673123487));
            temPoints.Add(new Point(488.853754940711, 202.169491525424));
            temPoints.Add(new Point(492.842809364548, 202.992736077482));
            temPoints.Add(new Point(496.248099726361, 203.767554479419));
            temPoints.Add(new Point(499.118273031317, 204.639225181598));
            temPoints.Add(new Point(501.356035269079, 205.559322033898));
            temPoints.Add(new Point(503.155974460322, 206.576271186441));
            temPoints.Add(new Point(504.518090605047, 207.641646489104));
            temPoints.Add(new Point(505.539677713591, 208.852300242131));
            temPoints.Add(new Point(506.123441775616, 210.208232445521));
            temPoints.Add(new Point(506.512617816966, 211.661016949153));
            temPoints.Add(new Point(506.609911827303, 213.259079903148));
            temPoints.Add(new Point(506.463970811797, 215.002421307506));
            temPoints.Add(new Point(505.928853754941, 216.745762711864));
            temPoints.Add(new Point(505.19914867741, 218.731234866828));
            temPoints.Add(new Point(504.080267558528, 220.668280871671));
            temPoints.Add(new Point(502.766798418972, 222.799031476998));
            temPoints.Add(new Point(501.064153238066, 224.881355932203));
            temPoints.Add(new Point(499.166920036485, 227.108958837772));
            temPoints.Add(new Point(496.977804803892, 229.433414043584));
            temPoints.Add(new Point(494.594101550623, 231.951573849879));
            temPoints.Add(new Point(492.113104287017, 234.663438256659));
            temPoints.Add(new Point(489.486166007905, 237.714285714286));
            temPoints.Add(new Point(486.761933718455, 241.007263922518));
            temPoints.Add(new Point(483.989054423837, 244.445520581114));
            temPoints.Add(new Point(481.118881118881, 248.174334140436));
            temPoints.Add(new Point(478.102766798419, 252.145278450363));
            temPoints.Add(new Point(474.940711462451, 256.455205811138));
            temPoints.Add(new Point(471.681362116145, 261.152542372881));
            temPoints.Add(new Point(468.081483733658, 266.043583535109));
            temPoints.Add(new Point(464.384311340833, 271.128329297821));
            temPoints.Add(new Point(460.443903922165, 276.358353510896));
            temPoints.Add(new Point(456.406202493159, 281.975786924939));
            temPoints.Add(new Point(452.027972027972, 287.835351089588));
            temPoints.Add(new Point(447.698388567954, 293.985472154964));
            temPoints.Add(new Point(443.174217087261, 300.087167070218));
            temPoints.Add(new Point(438.601398601399, 306.237288135593));
            temPoints.Add(new Point(434.077227120705, 312.484261501211));
            temPoints.Add(new Point(429.601702645181, 318.973365617433));
            temPoints.Add(new Point(425.174825174825, 325.607748184019));
            temPoints.Add(new Point(420.699300699301, 332.145278450363));
            temPoints.Add(new Point(416.321070234114, 338.440677966102));
            temPoints.Add(new Point(411.991486774095, 344.784503631961));
            temPoints.Add(new Point(407.661903314077, 351.128329297821));
            temPoints.Add(new Point(403.429613864396, 357.423728813559));
            temPoints.Add(new Point(399.245971419884, 363.476997578692));
            temPoints.Add(new Point(395.208269990879, 369.28813559322));
            temPoints.Add(new Point(391.316509577379, 374.905569007264));
            temPoints.Add(new Point(387.667984189723, 380.61985472155));
            temPoints.Add(new Point(384.068105807236, 386.285714285714));
            temPoints.Add(new Point(380.516874429918, 391.903147699758));
            temPoints.Add(new Point(377.111584068106, 397.326876513317));
            temPoints.Add(new Point(373.754940711462, 402.605326876513));
            temPoints.Add(new Point(370.495591365157, 407.835351089588));
            temPoints.Add(new Point(367.430830039526, 412.823244552058));
            temPoints.Add(new Point(364.463362724232, 417.665859564165));
            temPoints.Add(new Point(361.690483429614, 422.072639225182));
            temPoints.Add(new Point(359.355427181514, 426.09200968523));
            temPoints.Add(new Point(357.263605959258, 429.627118644068));
            temPoints.Add(new Point(355.755548799027, 432.774818401937));
            temPoints.Add(new Point(354.49072666464, 435.389830508475));
            temPoints.Add(new Point(353.858315597446, 437.956416464891));
            temPoints.Add(new Point(353.225904530252, 439.796610169491));
            temPoints.Add(new Point(353.420492550927, 441.636803874092));
            temPoints.Add(new Point(353.420492550927, 443.041162227603));
            temPoints.Add(new Point(353.761021587109, 444.300242130751));
            temPoints.Add(new Point(354.052903618121, 444.978208232445));
            strokes.Add(temPoints);
            count7++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);

            #endregion
            #region 8

            name = "8";
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(508.799027059897, 225.801452784504));
            temPoints.Add(new Point(508.312557008209, 226.430992736077));
            temPoints.Add(new Point(507.242322894497, 226.721549636804));
            temPoints.Add(new Point(506.269382791122, 226.915254237288));
            temPoints.Add(new Point(505.247795682578, 227.254237288136));
            temPoints.Add(new Point(504.03162055336, 227.399515738499));
            temPoints.Add(new Point(502.766798418972, 227.641646489104));
            temPoints.Add(new Point(501.161447248404, 227.738498789346));
            temPoints.Add(new Point(499.507449072666, 227.883777239709));
            temPoints.Add(new Point(497.41562785041, 227.786924939467));
            temPoints.Add(new Point(495.226512617817, 227.835351089588));
            temPoints.Add(new Point(492.550927333536, 227.690072639225));
            temPoints.Add(new Point(489.729401033749, 227.690072639225));
            temPoints.Add(new Point(486.372757677105, 227.544794188862));
            temPoints.Add(new Point(482.821526299787, 227.593220338983));
            temPoints.Add(new Point(478.83247187595, 227.544794188862));
            temPoints.Add(new Point(474.697476436607, 227.690072639225));
            temPoints.Add(new Point(470.221951961082, 227.738498789346));
            temPoints.Add(new Point(465.795074490727, 227.883777239709));
            temPoints.Add(new Point(461.076314989358, 227.883777239709));
            temPoints.Add(new Point(456.454849498328, 227.980629539952));
            temPoints.Add(new Point(451.833384007297, 227.883777239709));
            temPoints.Add(new Point(447.45515354211, 227.690072639225));
            temPoints.Add(new Point(443.222864092429, 227.254237288136));
            temPoints.Add(new Point(439.282456673761, 226.624697336562));
            temPoints.Add(new Point(435.43934326543, 225.65617433414));
            temPoints.Add(new Point(432.034052903618, 224.639225181598));
            temPoints.Add(new Point(428.726056552143, 223.186440677966));
            temPoints.Add(new Point(426.001824262694, 221.636803874092));
            temPoints.Add(new Point(423.326238978413, 219.651331719128));
            temPoints.Add(new Point(421.088476740651, 217.617433414044));
            temPoints.Add(new Point(419.045302523563, 215.244552058111));
            temPoints.Add(new Point(417.391304347826, 212.774818401937));
            temPoints.Add(new Point(416.07783520827, 210.014527845036));
            temPoints.Add(new Point(415.104895104895, 207.108958837772));
            temPoints.Add(new Point(414.52113104287, 204.009685230024));
            temPoints.Add(new Point(414.277896017026, 200.765133171913));
            temPoints.Add(new Point(414.472484037701, 197.520581113801));
            temPoints.Add(new Point(414.958954089389, 194.130750605327));
            temPoints.Add(new Point(415.785953177258, 190.692493946731));
            temPoints.Add(new Point(416.953481301307, 187.205811138014));
            temPoints.Add(new Point(418.364244451201, 183.767554479419));
            temPoints.Add(new Point(420.066889632107, 180.18401937046));
            temPoints.Add(new Point(421.964122833688, 176.745762711864));
            temPoints.Add(new Point(424.007297050775, 173.35593220339));
            temPoints.Add(new Point(426.245059288538, 170.014527845036));
            temPoints.Add(new Point(428.774703557312, 166.769975786925));
            temPoints.Add(new Point(431.450288841593, 163.622276029056));
            temPoints.Add(new Point(434.369109151718, 160.571428571429));
            temPoints.Add(new Point(437.433870477349, 157.714285714286));
            temPoints.Add(new Point(440.644572818486, 155.099273607748));
            temPoints.Add(new Point(444.001216175129, 152.532687651332));
            temPoints.Add(new Point(447.45515354211, 150.111380145278));
            temPoints.Add(new Point(451.006384919428, 147.738498789346));
            temPoints.Add(new Point(454.654910307084, 145.365617433414));
            temPoints.Add(new Point(458.352082699909, 143.186440677966));
            temPoints.Add(new Point(462.19519610824, 141.055690072639));
            temPoints.Add(new Point(466.03830951657, 138.973365617433));
            temPoints.Add(new Point(470.027363940407, 136.98789346247));
            temPoints.Add(new Point(474.065065369413, 135.099273607748));
            temPoints.Add(new Point(478.102766798419, 133.35593220339));
            temPoints.Add(new Point(482.140468227425, 131.806295399516));
            temPoints.Add(new Point(486.226816661599, 130.450363196126));
            temPoints.Add(new Point(490.215871085436, 129.28813559322));
            temPoints.Add(new Point(494.204925509273, 128.319612590799));
            temPoints.Add(new Point(498.19397993311, 127.496368038741));
            temPoints.Add(new Point(502.134387351779, 126.915254237288));
            temPoints.Add(new Point(506.074794770447, 126.479418886199));
            temPoints.Add(new Point(509.917908178778, 126.188861985472));
            temPoints.Add(new Point(513.71237458194, 125.995157384988));
            temPoints.Add(new Point(517.360899969596, 125.995157384988));
            temPoints.Add(new Point(520.814837336576, 126.09200968523));
            temPoints.Add(new Point(524.025539677714, 126.285714285714));
            temPoints.Add(new Point(526.993006993007, 126.673123486683));
            temPoints.Add(new Point(529.765886287625, 127.205811138015));
            temPoints.Add(new Point(532.246883551231, 127.883777239709));
            temPoints.Add(new Point(534.435998783825, 128.755447941889));
            temPoints.Add(new Point(536.333231985406, 129.869249394673));
            temPoints.Add(new Point(537.938583155974, 131.176755447942));
            temPoints.Add(new Point(539.300699300699, 132.726392251816));
            temPoints.Add(new Point(540.370933414412, 134.469733656174));
            temPoints.Add(new Point(541.149285497112, 136.406779661017));
            temPoints.Add(new Point(541.733049559136, 138.489104116223));
            temPoints.Add(new Point(542.122225600486, 140.668280871671));
            temPoints.Add(new Point(542.36546062633, 142.944309927361));
            temPoints.Add(new Point(542.462754636668, 145.220338983051));
            temPoints.Add(new Point(542.511401641836, 147.44794188862));
            temPoints.Add(new Point(542.511401641836, 149.72397094431));
            temPoints.Add(new Point(542.414107631499, 152));
            temPoints.Add(new Point(542.219519610824, 154.227602905569));
            temPoints.Add(new Point(541.927637579812, 156.503631961259));
            temPoints.Add(new Point(541.58710854363, 158.731234866828));
            temPoints.Add(new Point(541.100638491943, 161.10411622276));
            temPoints.Add(new Point(540.41958041958, 163.622276029056));
            temPoints.Add(new Point(539.592581331712, 166.334140435835));
            temPoints.Add(new Point(538.522347217999, 168.949152542373));
            temPoints.Add(new Point(537.306172088781, 171.661016949153));
            temPoints.Add(new Point(535.895408938887, 174.372881355932));
            temPoints.Add(new Point(534.290057768319, 177.133171912833));
            temPoints.Add(new Point(532.441471571906, 179.941888619855));
            temPoints.Add(new Point(530.495591365157, 182.702179176755));
            temPoints.Add(new Point(528.403770142901, 185.317191283293));
            temPoints.Add(new Point(526.263301915476, 188.029055690073));
            temPoints.Add(new Point(523.928245667376, 190.64406779661));
            temPoints.Add(new Point(521.495895408939, 193.404358353511));
            temPoints.Add(new Point(518.868957129827, 196.164648910412));
            temPoints.Add(new Point(516.193371845546, 199.070217917676));
            temPoints.Add(new Point(513.225904530252, 201.927360774818));
            temPoints.Add(new Point(510.20979020979, 204.881355932203));
            temPoints.Add(new Point(506.999087868653, 207.835351089588));
            temPoints.Add(new Point(503.788385527516, 210.886198547215));
            temPoints.Add(new Point(500.626330191548, 213.985472154964));
            temPoints.Add(new Point(497.366980845242, 217.133171912833));
            temPoints.Add(new Point(494.156278504105, 220.329297820823));
            temPoints.Add(new Point(491.091517178474, 223.670702179177));
            temPoints.Add(new Point(488.075402858012, 227.108958837772));
            temPoints.Add(new Point(485.059288537549, 230.595641646489));
            temPoints.Add(new Point(481.994527211918, 234.130750605327));
            temPoints.Add(new Point(478.978412891456, 237.762711864407));
            temPoints.Add(new Point(475.913651565825, 241.394673123487));
            temPoints.Add(new Point(472.946184250532, 245.123486682809));
            temPoints.Add(new Point(469.93006993007, 248.949152542373));
            temPoints.Add(new Point(467.059896625114, 252.871670702179));
            temPoints.Add(new Point(464.189723320158, 256.794188861985));
            temPoints.Add(new Point(461.562785041046, 260.861985472155));
            temPoints.Add(new Point(459.033140772271, 264.929782082324));
            temPoints.Add(new Point(456.698084524171, 269.094430992736));
            temPoints.Add(new Point(454.460322286409, 273.210653753027));
            temPoints.Add(new Point(452.417148069322, 277.326876513317));
            temPoints.Add(new Point(450.422620857403, 281.443099273608));
            temPoints.Add(new Point(448.525387655822, 285.559322033898));
            temPoints.Add(new Point(446.774095469748, 289.530266343826));
            temPoints.Add(new Point(445.168744299179, 293.452784503632));
            temPoints.Add(new Point(443.709334144117, 297.181598062954));
            temPoints.Add(new Point(442.444512009729, 300.861985472155));
            temPoints.Add(new Point(441.374277896017, 304.348668280872));
            temPoints.Add(new Point(440.595925813317, 307.690072639225));
            temPoints.Add(new Point(440.10945576163, 310.789346246973));
            temPoints.Add(new Point(439.914867740955, 313.646489104116));
            temPoints.Add(new Point(440.060808756461, 316.406779661017));
            temPoints.Add(new Point(440.449984797811, 319.118644067797));
            temPoints.Add(new Point(441.131042870173, 321.588377723971));
            temPoints.Add(new Point(441.958041958042, 323.912832929782));
            temPoints.Add(new Point(443.028276071754, 326.140435835351));
            temPoints.Add(new Point(444.293098206142, 328.174334140436));
            temPoints.Add(new Point(445.703861356035, 330.014527845036));
            temPoints.Add(new Point(447.309212526604, 331.661016949153));
            temPoints.Add(new Point(449.01185770751, 333.065375302663));
            temPoints.Add(new Point(451.006384919428, 334.27602905569));
            temPoints.Add(new Point(453.146853146853, 335.292978208232));
            temPoints.Add(new Point(455.481909394953, 336.164648910412));
            temPoints.Add(new Point(457.962906658559, 336.891041162228));
            temPoints.Add(new Point(460.687138948009, 337.569007263923));
            temPoints.Add(new Point(463.557312252964, 338.101694915254));
            temPoints.Add(new Point(466.670720583764, 338.585956416465));
            temPoints.Add(new Point(469.881422924901, 338.924939467312));
            temPoints.Add(new Point(473.140772271207, 339.167070217918));
            temPoints.Add(new Point(476.594709638188, 339.26392251816));
            temPoints.Add(new Point(480.194588020675, 339.312348668281));
            temPoints.Add(new Point(483.794466403162, 339.215496368039));
            temPoints.Add(new Point(487.442991790818, 338.924939467312));
            temPoints.Add(new Point(491.23745819398, 338.537530266344));
            temPoints.Add(new Point(495.031924597142, 338.053268765133));
            temPoints.Add(new Point(498.875038005473, 337.423728813559));
            temPoints.Add(new Point(502.669504408635, 336.745762711864));
            temPoints.Add(new Point(506.463970811797, 335.970944309927));
            temPoints.Add(new Point(510.161143204621, 335.002421307506));
            temPoints.Add(new Point(513.906962602615, 333.937046004843));
            temPoints.Add(new Point(517.506840985102, 332.774818401937));
            temPoints.Add(new Point(520.960778352083, 331.467312348668));
            temPoints.Add(new Point(524.366068713895, 329.966101694915));
            temPoints.Add(new Point(527.674065065369, 328.36803874092));
            temPoints.Add(new Point(530.884767406507, 326.624697336562));
            temPoints.Add(new Point(533.900881726969, 324.832929782082));
            temPoints.Add(new Point(536.722408026756, 322.992736077482));
            temPoints.Add(new Point(539.397993311037, 321.10411622276));
            temPoints.Add(new Point(541.927637579812, 319.167070217918));
            temPoints.Add(new Point(544.214046822742, 317.326876513317));
            temPoints.Add(new Point(546.25722103983, 315.438256658596));
            temPoints.Add(new Point(548.008513225904, 313.598062953995));
            temPoints.Add(new Point(549.662511401642, 311.757869249395));
            temPoints.Add(new Point(551.121921556704, 309.966101694915));
            temPoints.Add(new Point(552.43539069626, 308.125907990315));
            temPoints.Add(new Point(553.60291882031, 306.285714285714));
            temPoints.Add(new Point(554.575858923685, 304.348668280872));
            temPoints.Add(new Point(555.402858011554, 302.363196125908));
            temPoints.Add(new Point(556.132563089085, 300.280871670702));
            temPoints.Add(new Point(556.764974156279, 298.198547215496));
            temPoints.Add(new Point(557.300091213135, 296.067796610169));
            temPoints.Add(new Point(557.689267254485, 293.888619854722));
            temPoints.Add(new Point(557.981149285497, 291.709443099274));
            temPoints.Add(new Point(558.127090301003, 289.578692493947));
            temPoints.Add(new Point(558.175737306172, 287.44794188862));
            temPoints.Add(new Point(558.175737306172, 285.365617433414));
            temPoints.Add(new Point(558.029796290666, 283.283292978208));
            temPoints.Add(new Point(557.835208269991, 281.249394673124));
            temPoints.Add(new Point(557.591973244147, 279.26392251816));
            temPoints.Add(new Point(557.251444207966, 277.278450363196));
            temPoints.Add(new Point(556.910915171785, 275.292978208232));
            temPoints.Add(new Point(556.521739130435, 273.259079903148));
            temPoints.Add(new Point(556.083916083916, 271.273607748184));
            temPoints.Add(new Point(555.597446032229, 269.239709443099));
            temPoints.Add(new Point(555.062328975372, 267.351089588378));
            temPoints.Add(new Point(554.478564913347, 265.462469733656));
            temPoints.Add(new Point(553.748859835816, 263.622276029056));
            temPoints.Add(new Point(552.921860747948, 261.830508474576));
            temPoints.Add(new Point(551.997567649742, 260.135593220339));
            temPoints.Add(new Point(550.975980541198, 258.537530266344));
            temPoints.Add(new Point(549.905746427486, 257.036319612591));
            temPoints.Add(new Point(548.786865308604, 255.63196125908));
            temPoints.Add(new Point(547.619337184555, 254.324455205811));
            temPoints.Add(new Point(546.354515050167, 253.065375302663));
            temPoints.Add(new Point(545.041045910611, 251.806295399516));
            temPoints.Add(new Point(543.776223776224, 250.692493946731));
            temPoints.Add(new Point(542.414107631499, 249.530266343826));
            temPoints.Add(new Point(541.003344481605, 248.36803874092));
            temPoints.Add(new Point(539.543934326543, 247.254237288136));
            temPoints.Add(new Point(537.938583155974, 246.140435835351));
            temPoints.Add(new Point(536.381878990575, 245.075060532688));
            temPoints.Add(new Point(534.727880814837, 244.009685230024));
            temPoints.Add(new Point(533.025235633931, 242.944309927361));
            temPoints.Add(new Point(531.371237458194, 241.927360774818));
            temPoints.Add(new Point(529.619945272119, 240.861985472155));
            temPoints.Add(new Point(527.917300091213, 239.893462469734));
            temPoints.Add(new Point(526.263301915476, 238.876513317191));
            temPoints.Add(new Point(524.657950744907, 237.859564164649));
            temPoints.Add(new Point(523.052599574339, 236.842615012107));
            temPoints.Add(new Point(521.44724840377, 235.825665859564));
            temPoints.Add(new Point(519.841897233202, 234.760290556901));
            temPoints.Add(new Point(518.33384007297, 233.694915254237));
            temPoints.Add(new Point(516.923076923077, 232.581113801453));
            temPoints.Add(new Point(515.560960778352, 231.56416464891));
            temPoints.Add(new Point(514.247491638796, 230.547215496368));
            temPoints.Add(new Point(512.982669504409, 229.578692493947));
            temPoints.Add(new Point(511.815141380359, 228.707021791768));
            temPoints.Add(new Point(510.744907266646, 227.93220338983));
            temPoints.Add(new Point(509.674673152934, 227.302663438257));
            temPoints.Add(new Point(508.604439039222, 226.818401937046));
            temPoints.Add(new Point(507.582851930678, 226.52784503632));
            temPoints.Add(new Point(506.561264822134, 226.334140435835));
            temPoints.Add(new Point(505.636971723928, 226.285714285714));
            temPoints.Add(new Point(504.761325630891, 226.479418886199));
            temPoints.Add(new Point(503.885679537853, 226.576271186441));
            temPoints.Add(new Point(503.447856491335, 227.060532687651));
            temPoints.Add(new Point(502.718151413804, 227.108958837772));
            temPoints.Add(new Point(502.718151413804, 227.108958837772));
            temPoints.Add(new Point(502.718151413804, 227.108958837772));
            temPoints.Add(new Point(502.718151413804, 227.108958837772));
            strokes.Add(temPoints);
            count8++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(471.973244147157, 239.360774818402));
            temPoints.Add(new Point(471.340833079963, 239.651331719128));
            temPoints.Add(new Point(470.367892976589, 239.893462469734));
            temPoints.Add(new Point(469.15171784737, 239.893462469734));
            temPoints.Add(new Point(467.59501368197, 239.554479418886));
            temPoints.Add(new Point(465.941015506233, 239.360774818402));
            temPoints.Add(new Point(464.043782304652, 239.021791767554));
            temPoints.Add(new Point(462.049255092733, 238.634382566586));
            temPoints.Add(new Point(459.714198844634, 237.956416464891));
            temPoints.Add(new Point(457.330495591365, 237.278450363196));
            temPoints.Add(new Point(454.508969291578, 236.213075060533));
            temPoints.Add(new Point(451.73608999696, 235.099273607748));
            temPoints.Add(new Point(448.574034660991, 233.646489104116));
            temPoints.Add(new Point(445.363332319854, 232.145278450363));
            temPoints.Add(new Point(441.909394952873, 230.305084745763));
            temPoints.Add(new Point(438.504104591061, 228.319612590799));
            temPoints.Add(new Point(434.952873213743, 226.140435835351));
            temPoints.Add(new Point(431.401641836424, 223.81598062954));
            temPoints.Add(new Point(427.899057464275, 221.297820823245));
            temPoints.Add(new Point(424.493767102463, 218.585956416465));
            temPoints.Add(new Point(421.137123745819, 215.63196125908));
            temPoints.Add(new Point(417.975068409851, 212.532687651332));
            temPoints.Add(new Point(414.958954089389, 209.191283292978));
            temPoints.Add(new Point(412.18607479477, 205.65617433414));
            temPoints.Add(new Point(409.656430525996, 201.878934624697));
            temPoints.Add(new Point(407.515962298571, 197.90799031477));
            temPoints.Add(new Point(405.716023107327, 193.8401937046));
            temPoints.Add(new Point(404.45120097294, 189.627118644068));
            temPoints.Add(new Point(403.624201885071, 185.220338983051));
            temPoints.Add(new Point(403.28367284889, 180.765133171913));
            temPoints.Add(new Point(403.526907874734, 176.309927360775));
            temPoints.Add(new Point(404.256612952265, 171.806295399516));
            temPoints.Add(new Point(405.521435086652, 167.351089588378));
            temPoints.Add(new Point(407.224080267559, 163.041162227603));
            temPoints.Add(new Point(409.364548494983, 158.779661016949));
            temPoints.Add(new Point(411.79689875342, 154.663438256659));
            temPoints.Add(new Point(414.715719063545, 150.789346246973));
            temPoints.Add(new Point(417.829127394345, 147.108958837772));
            temPoints.Add(new Point(421.185770750988, 143.719128329298));
            temPoints.Add(new Point(424.785649133475, 140.61985472155));
            temPoints.Add(new Point(428.4828215263, 137.859564164649));
            temPoints.Add(new Point(432.325934934631, 135.389830508475));
            temPoints.Add(new Point(436.314989358468, 133.259079903148));
            temPoints.Add(new Point(440.304043782305, 131.467312348668));
            temPoints.Add(new Point(444.34174521131, 130.1598062954));
            temPoints.Add(new Point(448.428093645485, 129.239709443099));
            temPoints.Add(new Point(452.514442079659, 128.658595641646));
            temPoints.Add(new Point(456.600790513834, 128.416464891041));
            temPoints.Add(new Point(460.63849194284, 128.561743341404));
            temPoints.Add(new Point(464.627546366677, 129.094430992736));
            temPoints.Add(new Point(468.422012769839, 129.917675544794));
            temPoints.Add(new Point(472.216479173001, 131.128329297821));
            temPoints.Add(new Point(475.621769534813, 132.677966101695));
            temPoints.Add(new Point(478.978412891456, 134.566585956416));
            temPoints.Add(new Point(482.043174217087, 136.697336561743));
            temPoints.Add(new Point(484.864700516874, 139.070217917676));
            temPoints.Add(new Point(487.34569778048, 141.636803874092));
            temPoints.Add(new Point(489.534813013074, 144.445520581114));
            temPoints.Add(new Point(491.432046214655, 147.351089588378));
            temPoints.Add(new Point(493.037397385223, 150.353510895884));
            temPoints.Add(new Point(494.35086652478, 153.35593220339));
            temPoints.Add(new Point(495.275159622986, 156.406779661017));
            temPoints.Add(new Point(495.810276679842, 159.506053268765));
            temPoints.Add(new Point(496.102158710854, 162.653753026634));
            temPoints.Add(new Point(496.053511705686, 165.898305084746));
            temPoints.Add(new Point(495.761629674673, 169.094430992736));
            temPoints.Add(new Point(495.177865612648, 172.290556900726));
            temPoints.Add(new Point(494.302219519611, 175.583535108959));
            temPoints.Add(new Point(493.231985405898, 178.924939467312));
            temPoints.Add(new Point(491.821222256005, 182.314769975787));
            temPoints.Add(new Point(490.264518090605, 185.753026634383));
            temPoints.Add(new Point(488.610519914868, 189.336561743341));
            temPoints.Add(new Point(486.761933718455, 192.871670702179));
            temPoints.Add(new Point(484.816053511706, 196.503631961259));
            temPoints.Add(new Point(482.72423228945, 200.087167070218));
            temPoints.Add(new Point(480.486470051687, 203.81598062954));
            temPoints.Add(new Point(478.151413803588, 207.496368038741));
            temPoints.Add(new Point(475.767710550319, 211.176755447942));
            temPoints.Add(new Point(473.286713286713, 214.953995157385));
            temPoints.Add(new Point(470.611128002432, 218.731234866828));
            temPoints.Add(new Point(467.838248707814, 222.605326876513));
            temPoints.Add(new Point(464.87078139252, 226.52784503632));
            temPoints.Add(new Point(461.80602006689, 230.547215496368));
            temPoints.Add(new Point(458.69261173609, 234.566585956416));
            temPoints.Add(new Point(455.433262389784, 238.682808716707));
            temPoints.Add(new Point(452.076619033141, 242.992736077482));
            temPoints.Add(new Point(448.719975676497, 247.351089588378));
            temPoints.Add(new Point(445.314685314685, 251.903147699758));
            temPoints.Add(new Point(441.958041958042, 256.55205811138));
            temPoints.Add(new Point(438.650045606567, 261.346246973366));
            temPoints.Add(new Point(435.342049255093, 266.188861985472));
            temPoints.Add(new Point(432.179993919124, 271.225181598063));
            temPoints.Add(new Point(429.212526603831, 276.358353510896));
            temPoints.Add(new Point(426.439647309212, 281.53995157385));
            temPoints.Add(new Point(423.910003040438, 286.624697336562));
            temPoints.Add(new Point(421.623593797507, 291.661016949153));
            temPoints.Add(new Point(419.629066585588, 296.503631961259));
            temPoints.Add(new Point(417.926421404682, 301.249394673124));
            temPoints.Add(new Point(416.661599270295, 305.898305084746));
            temPoints.Add(new Point(415.68865916692, 310.353510895884));
            temPoints.Add(new Point(415.104895104895, 314.663438256659));
            temPoints.Add(new Point(414.813013073883, 318.82808716707));
            temPoints.Add(new Point(414.958954089389, 322.702179176755));
            temPoints.Add(new Point(415.396777135908, 326.479418886199));
            temPoints.Add(new Point(416.126482213439, 329.966101694915));
            temPoints.Add(new Point(417.196716327151, 333.307506053269));
            temPoints.Add(new Point(418.607479477045, 336.309927360775));
            temPoints.Add(new Point(420.310124657951, 339.070217917676));
            temPoints.Add(new Point(422.207357859532, 341.491525423729));
            temPoints.Add(new Point(424.396473092125, 343.573849878935));
            temPoints.Add(new Point(426.780176345394, 345.317191283293));
            temPoints.Add(new Point(429.455761629675, 346.721549636804));
            temPoints.Add(new Point(432.374581939799, 347.786924939467));
            temPoints.Add(new Point(435.536637275768, 348.561743341404));
            temPoints.Add(new Point(438.844633627242, 348.949152542373));
            temPoints.Add(new Point(442.444512009729, 349.094430992736));
            temPoints.Add(new Point(446.190331407723, 348.900726392252));
            temPoints.Add(new Point(450.082091821222, 348.464891041162));
            temPoints.Add(new Point(454.168440255397, 347.835351089588));
            temPoints.Add(new Point(458.30343569474, 346.915254237288));
            temPoints.Add(new Point(462.389784128915, 345.849878934625));
            temPoints.Add(new Point(466.476132563089, 344.542372881356));
            temPoints.Add(new Point(470.513833992095, 343.089588377724));
            temPoints.Add(new Point(474.551535421101, 341.491525423729));
            temPoints.Add(new Point(478.491942839769, 339.74818401937));
            temPoints.Add(new Point(482.383703253268, 337.956416464891));
            temPoints.Add(new Point(486.178169656431, 336.019370460048));
            temPoints.Add(new Point(489.826695044086, 334.082324455206));
            temPoints.Add(new Point(493.329279416236, 331.951573849879));
            temPoints.Add(new Point(496.734569778048, 329.772397094431));
            temPoints.Add(new Point(499.945272119185, 327.593220338983));
            temPoints.Add(new Point(502.815445424141, 325.365617433414));
            temPoints.Add(new Point(505.442383703253, 323.089588377724));
            temPoints.Add(new Point(507.728792946184, 320.813559322034));
            temPoints.Add(new Point(509.577379142597, 318.634382566586));
            temPoints.Add(new Point(511.085436302828, 316.503631961259));
            temPoints.Add(new Point(512.204317421709, 314.469733656174));
            temPoints.Add(new Point(512.982669504409, 312.532687651332));
            temPoints.Add(new Point(513.371845545759, 310.595641646489));
            temPoints.Add(new Point(513.566433566433, 308.658595641646));
            temPoints.Add(new Point(513.517786561265, 306.769975786925));
            temPoints.Add(new Point(513.274551535421, 304.832929782082));
            temPoints.Add(new Point(512.93402249924, 302.847457627119));
            temPoints.Add(new Point(512.496199452721, 300.716707021792));
            temPoints.Add(new Point(511.961082395865, 298.537530266344));
            temPoints.Add(new Point(511.37731833384, 296.261501210654));
            temPoints.Add(new Point(510.744907266646, 293.888619854722));
            temPoints.Add(new Point(510.063849194284, 291.467312348668));
            temPoints.Add(new Point(509.382791121922, 288.997578692494));
            temPoints.Add(new Point(508.701733049559, 286.479418886199));
            temPoints.Add(new Point(508.020674977197, 283.81598062954));
            temPoints.Add(new Point(507.339616904834, 281.249394673124));
            temPoints.Add(new Point(506.561264822134, 278.585956416465));
            temPoints.Add(new Point(505.831559744603, 275.922518159806));
            temPoints.Add(new Point(505.004560656735, 273.259079903148));
            temPoints.Add(new Point(504.128914563697, 270.64406779661));
            temPoints.Add(new Point(503.155974460322, 268.077481840194));
            temPoints.Add(new Point(502.08574034661, 265.607748184019));
            temPoints.Add(new Point(500.869565217391, 263.234866828087));
            temPoints.Add(new Point(499.458802067498, 260.958837772397));
            temPoints.Add(new Point(497.999391912435, 258.779661016949));
            temPoints.Add(new Point(496.394040741867, 256.697336561743));
            temPoints.Add(new Point(494.740042566129, 254.760290556901));
            temPoints.Add(new Point(492.988750380055, 252.871670702179));
            temPoints.Add(new Point(491.140164183642, 251.0799031477));
            temPoints.Add(new Point(489.194283976893, 249.384987893462));
            temPoints.Add(new Point(487.34569778048, 247.738498789346));
            temPoints.Add(new Point(485.448464578899, 246.237288135593));
            temPoints.Add(new Point(483.648525387656, 244.784503631961));
            temPoints.Add(new Point(481.799939191244, 243.476997578692));
            temPoints.Add(new Point(479.902705989662, 242.314769975787));
            temPoints.Add(new Point(478.102766798419, 241.200968523002));
            temPoints.Add(new Point(476.302827607175, 240.232445520581));
            temPoints.Add(new Point(474.600182426269, 239.312348668281));
            temPoints.Add(new Point(472.994831255701, 238.537530266344));
            temPoints.Add(new Point(471.194892064457, 237.569007263923));
            temPoints.Add(new Point(469.93006993007, 237.133171912833));
            temPoints.Add(new Point(468.178777743995, 236.164648910412));
            temPoints.Add(new Point(466.865308604439, 235.389830508475));
            temPoints.Add(new Point(465.25995743387, 234.324455205811));
            strokes.Add(temPoints);
            count8++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);

            #endregion
            #region 9

            name = "9";
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(532.976588628763, 247.302663438257));
            temPoints.Add(new Point(533.560352690787, 248.029055690073));
            temPoints.Add(new Point(533.560352690787, 248.029055690073));
            temPoints.Add(new Point(533.560352690787, 248.029055690073));
            temPoints.Add(new Point(533.560352690787, 248.029055690073));
            temPoints.Add(new Point(533.511705685619, 248.464891041162));
            temPoints.Add(new Point(533.511705685619, 248.464891041162));
            temPoints.Add(new Point(532.976588628763, 248.852300242131));
            temPoints.Add(new Point(532.490118577075, 249.142857142857));
            temPoints.Add(new Point(531.565825478869, 249.239709443099));
            temPoints.Add(new Point(530.592885375494, 249.578692493947));
            temPoints.Add(new Point(528.987534204926, 249.772397094431));
            temPoints.Add(new Point(527.284889024019, 250.1598062954));
            temPoints.Add(new Point(525.047126786257, 250.498789346247));
            temPoints.Add(new Point(522.566129522651, 251.0799031477));
            temPoints.Add(new Point(519.550015202189, 251.56416464891));
            temPoints.Add(new Point(516.339312861052, 252.193704600484));
            temPoints.Add(new Point(512.642140468227, 252.871670702179));
            temPoints.Add(new Point(508.604439039222, 253.743341404358));
            temPoints.Add(new Point(504.226208574035, 254.518159806295));
            temPoints.Add(new Point(499.896625114016, 255.389830508475));
            temPoints.Add(new Point(495.421100638492, 256.116222760291));
            temPoints.Add(new Point(491.042870173305, 256.794188861985));
            temPoints.Add(new Point(486.713286713287, 257.326876513317));
            temPoints.Add(new Point(482.529644268775, 257.714285714286));
            temPoints.Add(new Point(478.394648829431, 257.762711864407));
            temPoints.Add(new Point(474.648829431438, 257.665859564165));
            temPoints.Add(new Point(471.048951048951, 257.181598062954));
            temPoints.Add(new Point(467.59501368197, 256.55205811138));
            temPoints.Add(new Point(464.287017330496, 255.583535108959));
            temPoints.Add(new Point(461.270903010033, 254.469733656174));
            temPoints.Add(new Point(458.352082699909, 253.162227602906));
            temPoints.Add(new Point(455.773791425965, 251.661016949153));
            temPoints.Add(new Point(453.536029188203, 250.014527845036));
            temPoints.Add(new Point(451.541501976285, 248.271186440678));
            temPoints.Add(new Point(449.79020979021, 246.430992736077));
            temPoints.Add(new Point(448.282152629979, 244.397094430993));
            temPoints.Add(new Point(446.871389480085, 242.314769975787));
            temPoints.Add(new Point(445.557920340529, 240.038740920097));
            temPoints.Add(new Point(444.487686226817, 237.665859564165));
            temPoints.Add(new Point(443.514746123442, 235.050847457627));
            temPoints.Add(new Point(442.639100030404, 232.387409200969));
            temPoints.Add(new Point(441.763453937367, 229.530266343826));
            temPoints.Add(new Point(441.082395865005, 226.576271186441));
            temPoints.Add(new Point(440.49863180298, 223.573849878935));
            temPoints.Add(new Point(440.012161751292, 220.474576271186));
            temPoints.Add(new Point(439.72027972028, 217.375302663438));
            temPoints.Add(new Point(439.525691699605, 214.227602905569));
            temPoints.Add(new Point(439.477044694436, 211.176755447942));
            temPoints.Add(new Point(439.428397689267, 208.029055690073));
            temPoints.Add(new Point(439.477044694436, 204.881355932203));
            temPoints.Add(new Point(439.574338704773, 201.830508474576));
            temPoints.Add(new Point(439.72027972028, 198.779661016949));
            temPoints.Add(new Point(439.866220735786, 195.874092009685));
            temPoints.Add(new Point(440.158102766798, 193.016949152542));
            temPoints.Add(new Point(440.401337792642, 190.256658595642));
            temPoints.Add(new Point(440.741866828823, 187.496368038741));
            temPoints.Add(new Point(441.179689875342, 184.929782082324));
            temPoints.Add(new Point(441.763453937367, 182.508474576271));
            temPoints.Add(new Point(442.395865004561, 180.135593220339));
            temPoints.Add(new Point(443.125570082092, 177.859564164649));
            temPoints.Add(new Point(444.001216175129, 175.583535108959));
            temPoints.Add(new Point(444.876862268167, 173.307506053269));
            temPoints.Add(new Point(445.849802371542, 170.983050847458));
            temPoints.Add(new Point(447.017330495591, 168.707021791768));
            temPoints.Add(new Point(448.282152629979, 166.382566585956));
            temPoints.Add(new Point(449.595621769535, 164.106537530266));
            temPoints.Add(new Point(451.006384919428, 161.830508474576));
            temPoints.Add(new Point(452.563089084828, 159.651331719128));
            temPoints.Add(new Point(454.265734265734, 157.617433414044));
            temPoints.Add(new Point(456.114320462147, 155.728813559322));
            temPoints.Add(new Point(458.108847674065, 153.985472154964));
            temPoints.Add(new Point(460.103374885984, 152.338983050847));
            temPoints.Add(new Point(462.243843113408, 150.837772397094));
            temPoints.Add(new Point(464.432958346002, 149.481840193705));
            temPoints.Add(new Point(466.622073578595, 148.319612590799));
            temPoints.Add(new Point(468.811188811189, 147.302663438257));
            temPoints.Add(new Point(470.903010033445, 146.479418886199));
            temPoints.Add(new Point(472.946184250532, 145.753026634383));
            temPoints.Add(new Point(474.940711462451, 145.268765133172));
            temPoints.Add(new Point(476.837944664032, 145.026634382567));
            temPoints.Add(new Point(478.589236850106, 144.929782082324));
            temPoints.Add(new Point(480.340529036181, 144.978208232446));
            temPoints.Add(new Point(482.091821222256, 145.17191283293));
            temPoints.Add(new Point(483.843113408331, 145.510895883777));
            temPoints.Add(new Point(485.545758589237, 146.09200968523));
            temPoints.Add(new Point(487.34569778048, 146.818401937046));
            temPoints.Add(new Point(489.096989966555, 147.593220338983));
            temPoints.Add(new Point(490.994223168136, 148.561743341404));
            temPoints.Add(new Point(492.940103374886, 149.578692493947));
            temPoints.Add(new Point(494.885983581636, 150.740920096852));
            temPoints.Add(new Point(496.831863788385, 152));
            temPoints.Add(new Point(498.777743995135, 153.404358353511));
            temPoints.Add(new Point(500.626330191548, 154.857142857143));
            temPoints.Add(new Point(502.426269382791, 156.455205811138));
            temPoints.Add(new Point(504.226208574035, 158.295399515738));
            temPoints.Add(new Point(505.928853754941, 160.280871670702));
            temPoints.Add(new Point(507.485557920341, 162.46004842615));
            temPoints.Add(new Point(509.090909090909, 164.73607748184));
            temPoints.Add(new Point(510.59896625114, 167.157384987893));
            temPoints.Add(new Point(512.107023411371, 169.578692493947));
            temPoints.Add(new Point(513.566433566433, 172.145278450363));
            temPoints.Add(new Point(514.977196716327, 174.663438256659));
            temPoints.Add(new Point(516.290665855883, 177.181598062954));
            temPoints.Add(new Point(517.604134995439, 179.699757869249));
            temPoints.Add(new Point(518.820310124658, 182.169491525424));
            temPoints.Add(new Point(519.987838248708, 184.687651331719));
            temPoints.Add(new Point(521.155366372758, 187.254237288136));
            temPoints.Add(new Point(522.176953481301, 189.966101694915));
            temPoints.Add(new Point(523.198540589845, 192.629539951574));
            temPoints.Add(new Point(524.220127698389, 195.438256658596));
            temPoints.Add(new Point(525.241714806932, 198.246973365617));
            temPoints.Add(new Point(526.166007905138, 201.152542372881));
            temPoints.Add(new Point(526.944359987838, 204.058111380145));
            temPoints.Add(new Point(527.674065065369, 207.060532687651));
            temPoints.Add(new Point(528.355123137732, 210.062953995157));
            temPoints.Add(new Point(529.036181210094, 213.065375302663));
            temPoints.Add(new Point(529.717239282457, 216.116222760291));
            temPoints.Add(new Point(530.398297354819, 219.215496368039));
            temPoints.Add(new Point(531.079355427181, 222.266343825666));
            temPoints.Add(new Point(531.857707509881, 225.317191283293));
            temPoints.Add(new Point(532.782000608088, 228.271186440678));
            temPoints.Add(new Point(533.754940711462, 231.225181598063));
            temPoints.Add(new Point(534.825174825175, 233.985472154964));
            temPoints.Add(new Point(535.944055944056, 236.745762711864));
            temPoints.Add(new Point(537.111584068106, 239.312348668281));
            temPoints.Add(new Point(538.425053207662, 241.878934624697));
            temPoints.Add(new Point(539.64122833688, 244.493946731235));
            temPoints.Add(new Point(540.857403466099, 247.157384987893));
            temPoints.Add(new Point(542.024931590149, 249.869249394673));
            temPoints.Add(new Point(543.14381270903, 252.726392251816));
            temPoints.Add(new Point(544.214046822742, 255.63196125908));
            temPoints.Add(new Point(545.235633931286, 258.585956416465));
            temPoints.Add(new Point(546.159927029492, 261.685230024213));
            temPoints.Add(new Point(546.986926117361, 264.73607748184));
            temPoints.Add(new Point(547.716631194892, 267.883777239709));
            temPoints.Add(new Point(548.349042262086, 271.0799031477));
            temPoints.Add(new Point(548.932806324111, 274.324455205811));
            temPoints.Add(new Point(549.467923380967, 277.714285714286));
            temPoints.Add(new Point(549.905746427486, 281.200968523002));
            temPoints.Add(new Point(550.294922468835, 284.784503631961));
            temPoints.Add(new Point(550.586804499848, 288.36803874092));
            temPoints.Add(new Point(550.830039525692, 292.096852300242));
            temPoints.Add(new Point(551.024627546367, 295.825665859564));
            temPoints.Add(new Point(551.170568561873, 299.602905569007));
            temPoints.Add(new Point(551.26786257221, 303.476997578692));
            temPoints.Add(new Point(551.26786257221, 307.44794188862));
            temPoints.Add(new Point(551.219215567042, 311.418886198547));
            temPoints.Add(new Point(551.121921556704, 315.438256658596));
            temPoints.Add(new Point(550.975980541198, 319.554479418886));
            temPoints.Add(new Point(550.732745515354, 323.622276029056));
            temPoints.Add(new Point(550.392216479173, 327.641646489104));
            temPoints.Add(new Point(549.954393432654, 331.56416464891));
            temPoints.Add(new Point(549.419276375798, 335.389830508475));
            temPoints.Add(new Point(548.835512313773, 339.118644067797));
            temPoints.Add(new Point(548.105807236242, 342.653753026634));
            temPoints.Add(new Point(547.327455153542, 346.140435835351));
            temPoints.Add(new Point(546.451809060505, 349.336561743341));
            temPoints.Add(new Point(545.381574946792, 352.43583535109));
            temPoints.Add(new Point(544.31134083308, 355.438256658596));
            temPoints.Add(new Point(543.095165703861, 358.246973365617));
            temPoints.Add(new Point(541.781696564305, 360.861985472155));
            temPoints.Add(new Point(540.370933414412, 363.283292978208));
            temPoints.Add(new Point(538.814229249012, 365.462469733656));
            temPoints.Add(new Point(537.111584068106, 367.544794188862));
            temPoints.Add(new Point(535.165703861356, 369.481840193705));
            temPoints.Add(new Point(533.171176649437, 371.322033898305));
            temPoints.Add(new Point(530.982061416844, 372.968523002421));
            temPoints.Add(new Point(528.695652173913, 374.566585956416));
            temPoints.Add(new Point(526.311948920645, 376.067796610169));
            temPoints.Add(new Point(523.830951657039, 377.423728813559));
            temPoints.Add(new Point(521.155366372758, 378.682808716707));
            temPoints.Add(new Point(518.431134083308, 379.796610169491));
            temPoints.Add(new Point(515.65825478869, 380.668280871671));
            temPoints.Add(new Point(512.836728488902, 381.443099273608));
            temPoints.Add(new Point(509.771967163271, 382.024213075061));
            temPoints.Add(new Point(506.658558832472, 382.363196125908));
            temPoints.Add(new Point(503.399209486166, 382.508474576271));
            temPoints.Add(new Point(500.13986013986, 382.46004842615));
            temPoints.Add(new Point(496.929157798723, 382.169491525424));
            temPoints.Add(new Point(493.669808452417, 381.733656174334));
            temPoints.Add(new Point(490.507753116449, 381.10411622276));
            temPoints.Add(new Point(487.34569778048, 380.280871670702));
            temPoints.Add(new Point(484.28093645485, 379.360774818402));
            temPoints.Add(new Point(481.264822134387, 378.246973365617));
            temPoints.Add(new Point(478.248707813925, 376.98789346247));
            temPoints.Add(new Point(475.329887503801, 375.583535108959));
            temPoints.Add(new Point(472.411067193676, 374.033898305085));
            temPoints.Add(new Point(469.54089388872, 372.290556900726));
            temPoints.Add(new Point(466.81666159927, 370.401937046005));
            temPoints.Add(new Point(464.141076314989, 368.36803874092));
            temPoints.Add(new Point(461.562785041046, 366.188861985472));
            temPoints.Add(new Point(459.08178777744, 363.864406779661));
            temPoints.Add(new Point(456.74673152934, 361.443099273608));
            temPoints.Add(new Point(454.508969291578, 358.82808716707));
            temPoints.Add(new Point(452.417148069322, 356.213075060533));
            temPoints.Add(new Point(450.471267862572, 353.501210653753));
            temPoints.Add(new Point(448.671328671329, 350.837772397094));
            temPoints.Add(new Point(447.06597750076, 348.077481840194));
            temPoints.Add(new Point(445.752508361204, 345.414043583535));
            temPoints.Add(new Point(444.536333231985, 342.605326876513));
            temPoints.Add(new Point(443.709334144117, 340.135593220339));
            temPoints.Add(new Point(442.493159014898, 337.230024213075));
            temPoints.Add(new Point(441.860747947704, 334.808716707022));
            temPoints.Add(new Point(440.839160839161, 332));
            temPoints.Add(new Point(440.012161751292, 329.384987893462));
            strokes.Add(temPoints);
            count9++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(530.982061416844, 255.002421307506));
            temPoints.Add(new Point(531.468531468531, 255.728813559322));
            temPoints.Add(new Point(531.468531468531, 255.728813559322));
            temPoints.Add(new Point(531.468531468531, 255.728813559322));
            temPoints.Add(new Point(531.468531468531, 255.728813559322));
            temPoints.Add(new Point(531.468531468531, 255.728813559322));
            temPoints.Add(new Point(531.273943447856, 256.358353510896));
            temPoints.Add(new Point(530.738826391, 256.455205811138));
            temPoints.Add(new Point(530.301003344482, 256.98789346247));
            temPoints.Add(new Point(529.230769230769, 257.133171912833));
            temPoints.Add(new Point(528.160535117057, 257.762711864407));
            temPoints.Add(new Point(526.457889936151, 258.150121065375));
            temPoints.Add(new Point(524.657950744907, 258.876513317191));
            temPoints.Add(new Point(522.274247491639, 259.409200968523));
            temPoints.Add(new Point(519.744603222864, 260.18401937046));
            temPoints.Add(new Point(516.728488902402, 260.813559322034));
            temPoints.Add(new Point(513.566433566433, 261.588377723971));
            temPoints.Add(new Point(509.82061416844, 262.314769975787));
            temPoints.Add(new Point(505.880206749772, 263.041162227603));
            temPoints.Add(new Point(501.69656430526, 263.670702179177));
            temPoints.Add(new Point(497.366980845242, 264.300242130751));
            temPoints.Add(new Point(492.891456369717, 264.687651331719));
            temPoints.Add(new Point(488.464578899361, 265.026634382567));
            temPoints.Add(new Point(483.989054423837, 265.123486682809));
            temPoints.Add(new Point(479.513529948313, 265.075060532688));
            temPoints.Add(new Point(475.232593493463, 264.687651331719));
            temPoints.Add(new Point(471.09759805412, 264.106537530266));
            temPoints.Add(new Point(467.059896625114, 263.234866828087));
            temPoints.Add(new Point(463.168136211614, 262.217917675545));
            temPoints.Add(new Point(459.373669808452, 260.861985472155));
            temPoints.Add(new Point(455.773791425965, 259.360774818402));
            temPoints.Add(new Point(452.319854058984, 257.520581113801));
            temPoints.Add(new Point(449.206445728185, 255.583535108959));
            temPoints.Add(new Point(446.238978412891, 253.35593220339));
            temPoints.Add(new Point(443.466099118273, 251.031476997579));
            temPoints.Add(new Point(440.88780784433, 248.416464891041));
            temPoints.Add(new Point(438.601398601399, 245.753026634383));
            temPoints.Add(new Point(436.412283368805, 242.89588377724));
            temPoints.Add(new Point(434.417756156887, 239.845036319613));
            temPoints.Add(new Point(432.617816965643, 236.55205811138));
            temPoints.Add(new Point(431.012465795074, 233.162227602906));
            temPoints.Add(new Point(429.698996655518, 229.578692493947));
            temPoints.Add(new Point(428.531468531469, 225.946731234867));
            temPoints.Add(new Point(427.558528428094, 222.169491525424));
            temPoints.Add(new Point(426.731529340225, 218.295399515738));
            temPoints.Add(new Point(426.099118273031, 214.421307506053));
            temPoints.Add(new Point(425.612648221344, 210.547215496368));
            temPoints.Add(new Point(425.272119185163, 206.624697336562));
            temPoints.Add(new Point(425.077531164488, 202.799031476998));
            temPoints.Add(new Point(424.931590148981, 199.070217917676));
            temPoints.Add(new Point(424.931590148981, 195.389830508475));
            temPoints.Add(new Point(425.028884159319, 191.854721549637));
            temPoints.Add(new Point(425.272119185163, 188.271186440678));
            temPoints.Add(new Point(425.612648221344, 184.881355932203));
            temPoints.Add(new Point(426.099118273031, 181.588377723971));
            temPoints.Add(new Point(426.731529340225, 178.489104116223));
            temPoints.Add(new Point(427.558528428094, 175.486682808717));
            temPoints.Add(new Point(428.4828215263, 172.581113801453));
            temPoints.Add(new Point(429.553055640012, 169.772397094431));
            temPoints.Add(new Point(430.8178777744, 167.157384987893));
            temPoints.Add(new Point(432.277287929462, 164.73607748184));
            temPoints.Add(new Point(433.931286105199, 162.46004842615));
            temPoints.Add(new Point(435.731225296443, 160.377723970944));
            temPoints.Add(new Point(437.677105503192, 158.489104116223));
            temPoints.Add(new Point(439.768926725448, 156.745762711864));
            temPoints.Add(new Point(441.958041958042, 155.244552058111));
            temPoints.Add(new Point(444.244451200973, 153.937046004843));
            temPoints.Add(new Point(446.579507449073, 152.823244552058));
            temPoints.Add(new Point(448.817269686835, 151.854721549637));
            temPoints.Add(new Point(451.055031924597, 151.128329297821));
            temPoints.Add(new Point(453.292794162359, 150.595641646489));
            temPoints.Add(new Point(455.530556400122, 150.305084745763));
            temPoints.Add(new Point(457.865612648221, 150.111380145278));
            temPoints.Add(new Point(460.200668896321, 150.1598062954));
            temPoints.Add(new Point(462.487078139252, 150.401937046005));
            temPoints.Add(new Point(464.919428397689, 150.837772397094));
            temPoints.Add(new Point(467.400425661295, 151.467312348668));
            temPoints.Add(new Point(469.881422924901, 152.290556900726));
            temPoints.Add(new Point(472.362420188507, 153.259079903148));
            temPoints.Add(new Point(474.843417452113, 154.469733656174));
            temPoints.Add(new Point(477.178473700213, 155.777239709443));
            temPoints.Add(new Point(479.513529948313, 157.375302663438));
            temPoints.Add(new Point(481.751292186075, 159.167070217918));
            temPoints.Add(new Point(483.843113408331, 161.10411622276));
            temPoints.Add(new Point(485.837640620249, 163.234866828087));
            temPoints.Add(new Point(487.783520826999, 165.510895883777));
            temPoints.Add(new Point(489.68075402858, 167.932203389831));
            temPoints.Add(new Point(491.480693219824, 170.498789346247));
            temPoints.Add(new Point(493.329279416236, 173.210653753027));
            temPoints.Add(new Point(495.177865612648, 175.970944309927));
            temPoints.Add(new Point(497.075098814229, 178.82808716707));
            temPoints.Add(new Point(498.923685010642, 181.782082324455));
            temPoints.Add(new Point(500.723624201885, 184.881355932203));
            temPoints.Add(new Point(502.47491638796, 188.077481840194));
            temPoints.Add(new Point(504.128914563697, 191.467312348668));
            temPoints.Add(new Point(505.636971723928, 194.857142857143));
            temPoints.Add(new Point(507.047734873822, 198.392251815981));
            temPoints.Add(new Point(508.312557008209, 201.975786924939));
            temPoints.Add(new Point(509.528732137428, 205.65617433414));
            temPoints.Add(new Point(510.59896625114, 209.433414043584));
            temPoints.Add(new Point(511.620553359684, 213.259079903148));
            temPoints.Add(new Point(512.593493463059, 217.133171912833));
            temPoints.Add(new Point(513.566433566433, 220.958837772397));
            temPoints.Add(new Point(514.539373669808, 224.73607748184));
            temPoints.Add(new Point(515.560960778352, 228.464891041162));
            temPoints.Add(new Point(516.631194892064, 232.145278450363));
            temPoints.Add(new Point(517.750076010946, 235.777239709443));
            temPoints.Add(new Point(518.966251140164, 239.26392251816));
            temPoints.Add(new Point(520.27972027972, 242.653753026634));
            temPoints.Add(new Point(521.690483429614, 245.995157384988));
            temPoints.Add(new Point(523.198540589845, 249.336561743341));
            temPoints.Add(new Point(524.803891760413, 252.629539951574));
            temPoints.Add(new Point(526.409242930982, 255.922518159806));
            temPoints.Add(new Point(528.014594101551, 259.215496368039));
            temPoints.Add(new Point(529.57129826695, 262.556900726392));
            temPoints.Add(new Point(531.079355427181, 265.801452784504));
            temPoints.Add(new Point(532.538765582244, 269.142857142857));
            temPoints.Add(new Point(533.949528732137, 272.43583535109));
            temPoints.Add(new Point(535.165703861356, 275.825665859564));
            temPoints.Add(new Point(536.333231985406, 279.312348668281));
            temPoints.Add(new Point(537.354819093949, 282.847457627119));
            temPoints.Add(new Point(538.327759197324, 286.430992736077));
            temPoints.Add(new Point(539.349346305868, 290.014527845036));
            temPoints.Add(new Point(540.273639404074, 293.598062953995));
            temPoints.Add(new Point(541.100638491943, 297.133171912833));
            temPoints.Add(new Point(541.878990574643, 300.571428571429));
            temPoints.Add(new Point(542.560048647005, 303.961259079903));
            temPoints.Add(new Point(543.241106719368, 307.254237288136));
            temPoints.Add(new Point(543.824870781393, 310.595641646489));
            temPoints.Add(new Point(544.31134083308, 313.888619854722));
            temPoints.Add(new Point(544.651869869261, 317.036319612591));
            temPoints.Add(new Point(544.943751900274, 320.18401937046));
            temPoints.Add(new Point(545.138339920949, 323.331719128329));
            temPoints.Add(new Point(545.284280936455, 326.382566585956));
            temPoints.Add(new Point(545.284280936455, 329.336561743341));
            temPoints.Add(new Point(545.186986926117, 332.145278450363));
            temPoints.Add(new Point(544.895104895105, 334.905569007264));
            temPoints.Add(new Point(544.31134083308, 337.569007263923));
            temPoints.Add(new Point(543.630282760717, 340.329297820823));
            temPoints.Add(new Point(542.803283672849, 343.041162227603));
            temPoints.Add(new Point(541.781696564305, 345.65617433414));
            temPoints.Add(new Point(540.614168440255, 348.271186440678));
            temPoints.Add(new Point(539.300699300699, 350.837772397094));
            temPoints.Add(new Point(537.792642140468, 353.307506053269));
            temPoints.Add(new Point(536.138643964731, 355.680387409201));
            temPoints.Add(new Point(534.484645788994, 357.956416464891));
            temPoints.Add(new Point(532.636059592581, 360.087167070218));
            temPoints.Add(new Point(530.592885375494, 362.072639225182));
            temPoints.Add(new Point(528.452417148069, 363.961259079903));
            temPoints.Add(new Point(526.263301915476, 365.704600484262));
            temPoints.Add(new Point(523.976892672545, 367.399515738499));
            temPoints.Add(new Point(521.690483429614, 368.997578692494));
            temPoints.Add(new Point(519.258133171177, 370.595641646489));
            temPoints.Add(new Point(516.825782912739, 372));
            temPoints.Add(new Point(514.296138643965, 373.307506053269));
            temPoints.Add(new Point(511.76649437519, 374.469733656174));
            temPoints.Add(new Point(509.139556096078, 375.63196125908));
            temPoints.Add(new Point(506.318029796291, 376.648910411622));
            temPoints.Add(new Point(503.496503496503, 377.569007263923));
            temPoints.Add(new Point(500.52903618121, 378.246973365617));
            temPoints.Add(new Point(497.610215871085, 378.731234866828));
            temPoints.Add(new Point(494.691395560961, 378.973365617433));
            temPoints.Add(new Point(491.772575250836, 379.070217917676));
            temPoints.Add(new Point(488.853754940711, 378.876513317191));
            temPoints.Add(new Point(486.080875646093, 378.392251815981));
            temPoints.Add(new Point(483.405290361812, 377.617433414044));
            temPoints.Add(new Point(480.826999087869, 376.503631961259));
            temPoints.Add(new Point(478.346001824263, 375.19612590799));
            temPoints.Add(new Point(476.010945576163, 373.646489104116));
            temPoints.Add(new Point(473.578595317726, 372));
            temPoints.Add(new Point(471.194892064457, 370.062953995157));
            temPoints.Add(new Point(468.859835816358, 367.93220338983));
            temPoints.Add(new Point(466.476132563089, 365.753026634383));
            temPoints.Add(new Point(464.189723320158, 363.476997578692));
            temPoints.Add(new Point(461.903314077227, 361.10411622276));
            temPoints.Add(new Point(459.762845849802, 358.537530266344));
            temPoints.Add(new Point(457.671024627546, 355.970944309927));
            temPoints.Add(new Point(455.725144420797, 353.35593220339));
            temPoints.Add(new Point(453.973852234722, 350.886198547215));
            temPoints.Add(new Point(452.465795074491, 348.513317191283));
            temPoints.Add(new Point(451.200972940103, 346.188861985472));
            temPoints.Add(new Point(450.130738826391, 344.154963680387));
            temPoints.Add(new Point(449.206445728185, 342.169491525424));
            temPoints.Add(new Point(448.719975676497, 340.861985472155));
            temPoints.Add(new Point(447.892976588629, 339.118644067797));
            temPoints.Add(new Point(447.649741562785, 337.714285714286));
            temPoints.Add(new Point(447.06597750076, 335.922518159806));
            temPoints.Add(new Point(446.579507449073, 334.082324455206));
            strokes.Add(temPoints);
            count9++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);

            #endregion
            #region +

            name = "+";
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(631.243539069626, 252.43583535109));
            temPoints.Add(new Point(632.021891152326, 253.210653753027));
            temPoints.Add(new Point(632.021891152326, 253.210653753027));
            temPoints.Add(new Point(632.021891152326, 253.210653753027));
            temPoints.Add(new Point(632.459714198845, 253.549636803874));
            temPoints.Add(new Point(632.459714198845, 253.549636803874));
            temPoints.Add(new Point(632.459714198845, 253.549636803874));
            temPoints.Add(new Point(631.827303131651, 253.646489104116));
            temPoints.Add(new Point(631.146245059289, 253.743341404358));
            temPoints.Add(new Point(629.881422924901, 253.501210653753));
            temPoints.Add(new Point(628.616600790514, 253.501210653753));
            temPoints.Add(new Point(626.670720583764, 253.210653753027));
            temPoints.Add(new Point(624.627546366677, 253.210653753027));
            temPoints.Add(new Point(621.854667072058, 252.968523002421));
            temPoints.Add(new Point(619.033140772271, 253.065375302663));
            temPoints.Add(new Point(615.57920340529, 252.9200968523));
            temPoints.Add(new Point(612.076619033141, 252.968523002421));
            temPoints.Add(new Point(608.184858619641, 253.065375302663));
            temPoints.Add(new Point(604.001216175129, 253.259079903148));
            temPoints.Add(new Point(599.525691699605, 253.501210653753));
            temPoints.Add(new Point(594.758285193068, 253.8401937046));
            temPoints.Add(new Point(589.698996655518, 254.130750605327));
            temPoints.Add(new Point(584.493767102463, 254.469733656174));
            temPoints.Add(new Point(578.996655518395, 254.760290556901));
            temPoints.Add(new Point(573.596837944664, 255.099273607748));
            temPoints.Add(new Point(567.95378534509, 255.147699757869));
            temPoints.Add(new Point(562.456673761022, 255.292978208232));
            temPoints.Add(new Point(556.813621161447, 255.147699757869));
            temPoints.Add(new Point(551.413803587717, 255.002421307506));
            temPoints.Add(new Point(546.062633019155, 254.71186440678));
            temPoints.Add(new Point(541.051991486774, 254.372881355932));
            temPoints.Add(new Point(536.138643964731, 254.033898305085));
            temPoints.Add(new Point(531.468531468531, 253.694915254237));
            temPoints.Add(new Point(527.041653998176, 253.35593220339));
            temPoints.Add(new Point(522.809364548495, 253.016949152542));
            temPoints.Add(new Point(518.917604134995, 252.726392251816));
            temPoints.Add(new Point(515.317725752508, 252.484261501211));
            temPoints.Add(new Point(511.961082395865, 252.338983050847));
            temPoints.Add(new Point(508.847674065065, 252.242130750605));
            temPoints.Add(new Point(505.977500760109, 252.193704600484));
            temPoints.Add(new Point(503.301915475828, 252.193704600484));
            temPoints.Add(new Point(500.91821222256, 252.290556900726));
            temPoints.Add(new Point(498.729096989967, 252.338983050847));
            temPoints.Add(new Point(497.075098814229, 252.823244552058));
            temPoints.Add(new Point(495.372453633323, 252.9200968523));
            temPoints.Add(new Point(494.253572514442, 253.113801452785));
            temPoints.Add(new Point(493.231985405898, 253.016949152542));
            temPoints.Add(new Point(492.745515354211, 252.871670702179));
            temPoints.Add(new Point(556.764974156279, 210.789346246973));
            temPoints.Add(new Point(556.862268166616, 210.256658595642));
            temPoints.Add(new Point(556.71632715111, 209.384987893462));
            temPoints.Add(new Point(556.764974156279, 208.561743341404));
            temPoints.Add(new Point(556.959562176953, 207.786924939467));
            temPoints.Add(new Point(556.910915171785, 206.915254237288));
            temPoints.Add(new Point(557.056856187291, 206.334140435835));
            temPoints.Add(new Point(557.008209182122, 205.65617433414));
            temPoints.Add(new Point(557.008209182122, 205.65617433414));
            temPoints.Add(new Point(557.056856187291, 204.832929782082));
            temPoints.Add(new Point(557.056856187291, 204.832929782082));
            temPoints.Add(new Point(557.056856187291, 204.832929782082));
            temPoints.Add(new Point(557.640620249316, 204.929782082324));
            temPoints.Add(new Point(557.640620249316, 204.929782082324));
            temPoints.Add(new Point(558.467619337184, 205.946731234867));
            temPoints.Add(new Point(559.05138339921, 206.818401937046));
            temPoints.Add(new Point(559.732441471572, 207.980629539952));
            temPoints.Add(new Point(560.413499543934, 209.336561743341));
            temPoints.Add(new Point(561.143204621465, 211.0799031477));
            temPoints.Add(new Point(561.678321678322, 213.065375302663));
            temPoints.Add(new Point(562.262085740347, 215.486682808717));
            temPoints.Add(new Point(562.553967771359, 218.150121065375));
            temPoints.Add(new Point(562.89449680754, 221.249394673124));
            temPoints.Add(new Point(562.943143812709, 224.445520581114));
            temPoints.Add(new Point(562.991790817878, 228.029055690073));
            temPoints.Add(new Point(562.845849802372, 231.757869249395));
            temPoints.Add(new Point(562.89449680754, 235.825665859564));
            temPoints.Add(new Point(562.845849802372, 239.941888619855));
            temPoints.Add(new Point(562.991790817878, 244.397094430993));
            temPoints.Add(new Point(563.089084828215, 248.80387409201));
            temPoints.Add(new Point(563.380966859228, 253.35593220339));
            temPoints.Add(new Point(563.770142900578, 257.90799031477));
            temPoints.Add(new Point(564.305259957434, 262.556900726392));
            temPoints.Add(new Point(564.791730009121, 267.254237288136));
            temPoints.Add(new Point(565.375494071146, 272.096852300242));
            temPoints.Add(new Point(565.910611128002, 276.891041162228));
            temPoints.Add(new Point(566.494375190027, 281.636803874092));
            temPoints.Add(new Point(567.078139252052, 286.188861985472));
            temPoints.Add(new Point(567.56460930374, 290.789346246973));
            temPoints.Add(new Point(567.905138339921, 295.147699757869));
            temPoints.Add(new Point(568.148373365765, 299.457627118644));
            temPoints.Add(new Point(568.197020370933, 303.525423728814));
            temPoints.Add(new Point(568.148373365765, 307.399515738499));
            temPoints.Add(new Point(567.95378534509, 310.983050847458));
            temPoints.Add(new Point(567.56460930374, 314.372881355932));
            temPoints.Add(new Point(567.078139252052, 317.520581113801));
            temPoints.Add(new Point(566.543022195196, 320.329297820823));
            temPoints.Add(new Point(566.056552143509, 322.89588377724));
            temPoints.Add(new Point(565.521435086652, 325.026634382567));
            temPoints.Add(new Point(565.180906050471, 327.01210653753));
            temPoints.Add(new Point(564.645788993615, 328.125907990315));
            temPoints.Add(new Point(564.743083003953, 329.433414043584));
            temPoints.Add(new Point(564.548494983278, 329.966101694915));
            temPoints.Add(new Point(564.743083003953, 330.401937046005));
            temPoints.Add(new Point(564.743083003953, 330.401937046005));
            strokes.Add(temPoints);
            count10++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(668.799027059897, 231.225181598063));
            temPoints.Add(new Point(668.458498023715, 231.806295399516));
            temPoints.Add(new Point(668.458498023715, 231.806295399516));
            temPoints.Add(new Point(667.485557920341, 231.806295399516));
            temPoints.Add(new Point(666.561264822134, 231.661016949153));
            temPoints.Add(new Point(665.539677713591, 231.661016949153));
            temPoints.Add(new Point(664.128914563697, 231.709443099274));
            temPoints.Add(new Point(662.377622377622, 231.709443099274));
            temPoints.Add(new Point(660.042566129523, 231.661016949153));
            temPoints.Add(new Point(657.464274855579, 231.612590799031));
            temPoints.Add(new Point(654.399513529948, 231.370460048426));
            temPoints.Add(new Point(651.042870173305, 231.176755447942));
            temPoints.Add(new Point(647.102462754637, 230.886198547215));
            temPoints.Add(new Point(642.870173304956, 230.740920096852));
            temPoints.Add(new Point(638.05411979325, 230.498789346247));
            temPoints.Add(new Point(633.04347826087, 230.547215496368));
            temPoints.Add(new Point(627.59501368197, 230.64406779661));
            temPoints.Add(new Point(621.80602006689, 230.983050847458));
            temPoints.Add(new Point(615.384615384615, 231.467312348668));
            temPoints.Add(new Point(608.671328671329, 232.242130750605));
            temPoints.Add(new Point(601.374277896017, 233.065375302663));
            temPoints.Add(new Point(593.88263910003, 234.179176755448));
            temPoints.Add(new Point(585.953177257525, 235.292978208232));
            temPoints.Add(new Point(578.02371541502, 236.55205811138));
            temPoints.Add(new Point(570.094253572514, 237.762711864407));
            temPoints.Add(new Point(562.359379750684, 239.070217917676));
            temPoints.Add(new Point(554.965034965035, 240.18401937046));
            temPoints.Add(new Point(547.959866220736, 241.297820823245));
            temPoints.Add(new Point(541.538461538462, 242.169491525424));
            temPoints.Add(new Point(535.79811492855, 242.944309927361));
            temPoints.Add(new Point(530.641532380663, 243.525423728814));
            temPoints.Add(new Point(525.971419884463, 243.912832929782));
            temPoints.Add(new Point(521.885071450289, 244.106537530266));
            temPoints.Add(new Point(518.187899057464, 244.106537530266));
            temPoints.Add(new Point(515.074490726665, 244.106537530266));
            temPoints.Add(new Point(512.15567041654, 243.767554479419));
            temPoints.Add(new Point(510.20979020979, 243.81598062954));
            temPoints.Add(new Point(508.166615992703, 243.476997578692));
            temPoints.Add(new Point(506.755852842809, 243.234866828087));
            temPoints.Add(new Point(505.588324718759, 242.750605326876));
            temPoints.Add(new Point(567.905138339921, 194.130750605327));
            temPoints.Add(new Point(568.634843417452, 194.324455205811));
            temPoints.Add(new Point(568.634843417452, 194.324455205811));
            temPoints.Add(new Point(569.218607479477, 194.566585956416));
            temPoints.Add(new Point(569.218607479477, 194.566585956416));
            temPoints.Add(new Point(569.802371541502, 195.535108958838));
            temPoints.Add(new Point(570.094253572514, 196.406779661017));
            temPoints.Add(new Point(570.240194588021, 197.278450363196));
            temPoints.Add(new Point(570.288841593189, 198.392251815981));
            temPoints.Add(new Point(570.191547582852, 199.360774818402));
            temPoints.Add(new Point(570.240194588021, 200.523002421308));
            temPoints.Add(new Point(570.142900577683, 201.443099273608));
            temPoints.Add(new Point(570.434782608696, 202.605326876513));
            temPoints.Add(new Point(570.580723624202, 203.573849878935));
            temPoints.Add(new Point(571.067193675889, 204.881355932203));
            temPoints.Add(new Point(571.553663727577, 206.140435835351));
            temPoints.Add(new Point(572.283368805108, 207.641646489104));
            temPoints.Add(new Point(573.110367892977, 209.28813559322));
            temPoints.Add(new Point(574.083307996351, 211.273607748184));
            temPoints.Add(new Point(575.056248099726, 213.404358353511));
            temPoints.Add(new Point(576.029188203101, 216.019370460048));
            temPoints.Add(new Point(577.099422316814, 218.924939467312));
            temPoints.Add(new Point(578.169656430526, 222.072639225182));
            temPoints.Add(new Point(579.239890544238, 225.462469733656));
            temPoints.Add(new Point(580.407418668288, 229.094430992736));
            temPoints.Add(new Point(581.574946792338, 232.871670702179));
            temPoints.Add(new Point(582.888415931894, 236.794188861985));
            temPoints.Add(new Point(584.20188507145, 240.861985472155));
            temPoints.Add(new Point(585.612648221344, 245.026634382567));
            temPoints.Add(new Point(586.9261173609, 249.28813559322));
            temPoints.Add(new Point(588.336880510794, 253.646489104116));
            temPoints.Add(new Point(589.698996655518, 258.053268765133));
            temPoints.Add(new Point(590.915171784737, 262.46004842615));
            temPoints.Add(new Point(591.888111888112, 266.963680387409));
            temPoints.Add(new Point(592.812404986318, 271.56416464891));
            temPoints.Add(new Point(593.49346305868, 276.164648910412));
            temPoints.Add(new Point(594.028580115537, 280.668280871671));
            temPoints.Add(new Point(594.320462146549, 284.929782082324));
            temPoints.Add(new Point(594.515050167224, 289.142857142857));
            temPoints.Add(new Point(594.563697172393, 293.065375302663));
            temPoints.Add(new Point(594.612344177562, 296.745762711864));
            temPoints.Add(new Point(594.709638187899, 300.087167070218));
            temPoints.Add(new Point(594.758285193068, 302.944309927361));
            temPoints.Add(new Point(594.855579203405, 305.365617433414));
            temPoints.Add(new Point(594.952873213743, 307.399515738499));
            temPoints.Add(new Point(595.196108239586, 309.191283292978));
            temPoints.Add(new Point(595.293402249924, 310.256658595642));
            temPoints.Add(new Point(596.071754332624, 311.467312348668));
            temPoints.Add(new Point(596.314989358468, 311.951573849879));
            temPoints.Add(new Point(596.898753420493, 312.193704600484));
            temPoints.Add(new Point(597.190635451505, 311.709443099274));
            strokes.Add(temPoints);
            count10++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(662.037093341441, 205.704600484262));
            temPoints.Add(new Point(662.572210398297, 206.430992736077));
            temPoints.Add(new Point(662.572210398297, 206.430992736077));
            temPoints.Add(new Point(663.301915475829, 207.060532687651));
            temPoints.Add(new Point(663.301915475829, 207.060532687651));
            temPoints.Add(new Point(663.788385527516, 207.302663438257));
            temPoints.Add(new Point(663.788385527516, 207.302663438257));
            temPoints.Add(new Point(663.788385527516, 207.302663438257));
            temPoints.Add(new Point(663.350562480997, 207.254237288136));
            temPoints.Add(new Point(662.620857403466, 206.963680387409));
            temPoints.Add(new Point(661.891152325935, 206.963680387409));
            temPoints.Add(new Point(660.52903618121, 206.673123486683));
            temPoints.Add(new Point(659.069626026148, 206.673123486683));
            temPoints.Add(new Point(656.880510793554, 206.52784503632));
            temPoints.Add(new Point(654.399513529948, 206.624697336562));
            temPoints.Add(new Point(651.091517178474, 206.769975786925));
            temPoints.Add(new Point(647.34569778048, 207.060532687651));
            temPoints.Add(new Point(642.870173304956, 207.399515738499));
            temPoints.Add(new Point(637.908178777744, 207.980629539952));
            temPoints.Add(new Point(632.167832167832, 208.561743341404));
            temPoints.Add(new Point(626.03830951657, 209.28813559322));
            temPoints.Add(new Point(619.422316813621, 210.111380145278));
            temPoints.Add(new Point(612.465795074491, 210.983050847458));
            temPoints.Add(new Point(605.217391304348, 211.903147699758));
            temPoints.Add(new Point(597.725752508361, 212.823244552058));
            temPoints.Add(new Point(590.088172696868, 213.791767554479));
            temPoints.Add(new Point(582.353298875038, 214.663438256659));
            temPoints.Add(new Point(574.472484037701, 215.486682808717));
            temPoints.Add(new Point(566.640316205534, 216.406779661017));
            temPoints.Add(new Point(558.808148373366, 217.230024213075));
            temPoints.Add(new Point(551.170568561873, 218.101694915254));
            temPoints.Add(new Point(543.678929765886, 218.924939467312));
            temPoints.Add(new Point(536.479173000912, 219.796610169492));
            temPoints.Add(new Point(529.522651261782, 220.668280871671));
            temPoints.Add(new Point(522.955305564001, 221.53995157385));
            temPoints.Add(new Point(517.020370933414, 222.46004842615));
            temPoints.Add(new Point(511.571906354515, 223.138014527845));
            temPoints.Add(new Point(506.901793858316, 223.961259079903));
            temPoints.Add(new Point(502.620857403466, 224.300242130751));
            temPoints.Add(new Point(499.653390088173, 225.075060532688));
            temPoints.Add(new Point(497.02645180906, 225.17191283293));
            temPoints.Add(new Point(495.469747643661, 225.220338983051));
            temPoints.Add(new Point(494.545454545455, 224.881355932203));
            temPoints.Add(new Point(556.862268166616, 160.474576271186));
            temPoints.Add(new Point(557.397385223472, 161.782082324455));
            temPoints.Add(new Point(558.029796290666, 163.089588377724));
            temPoints.Add(new Point(558.905442383703, 164.493946731235));
            temPoints.Add(new Point(559.732441471572, 166.237288135593));
            temPoints.Add(new Point(560.754028580115, 167.980629539952));
            temPoints.Add(new Point(561.872909698997, 170.014527845036));
            temPoints.Add(new Point(562.991790817878, 172.290556900726));
            temPoints.Add(new Point(563.867436910915, 174.71186440678));
            temPoints.Add(new Point(564.597141988446, 177.520581113801));
            temPoints.Add(new Point(565.034965034965, 180.523002421308));
            temPoints.Add(new Point(565.472788081484, 184.009685230024));
            temPoints.Add(new Point(565.716023107327, 187.496368038741));
            temPoints.Add(new Point(566.056552143509, 191.515738498789));
            temPoints.Add(new Point(566.153846153846, 195.825665859564));
            temPoints.Add(new Point(566.348434174521, 200.523002421308));
            temPoints.Add(new Point(566.299787169352, 205.559322033898));
            temPoints.Add(new Point(566.251140164184, 210.934624697337));
            temPoints.Add(new Point(566.056552143509, 216.503631961259));
            temPoints.Add(new Point(565.910611128002, 222.217917675545));
            temPoints.Add(new Point(565.570082091821, 228.077481840194));
            temPoints.Add(new Point(565.132259045302, 234.082324455206));
            temPoints.Add(new Point(564.645788993615, 240.087167070218));
            temPoints.Add(new Point(564.110671936759, 246.09200968523));
            temPoints.Add(new Point(563.624201885071, 251.757869249395));
            temPoints.Add(new Point(563.235025843721, 257.230024213075));
            temPoints.Add(new Point(562.89449680754, 262.411622276029));
            temPoints.Add(new Point(562.602614776528, 267.399515738499));
            temPoints.Add(new Point(562.359379750684, 272.048426150121));
            temPoints.Add(new Point(562.164791730009, 276.164648910412));
            temPoints.Add(new Point(561.970203709334, 279.893462469734));
            temPoints.Add(new Point(561.72696868349, 283.138014527845));
            temPoints.Add(new Point(561.483733657647, 285.995157384988));
            temPoints.Add(new Point(560.948616600791, 288.222760290557));
            temPoints.Add(new Point(560.705381574947, 290.353510895884));
            temPoints.Add(new Point(559.732441471572, 291.515738498789));
            temPoints.Add(new Point(558.905442383703, 292.43583535109));
            temPoints.Add(new Point(557.49467923381, 292.581113801453));
            strokes.Add(temPoints);
            count10++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(622.049255092733, 212.677966101695));
            temPoints.Add(new Point(622.049255092733, 212.677966101695));
            temPoints.Add(new Point(622.827607175433, 213.646489104116));
            temPoints.Add(new Point(622.827607175433, 213.646489104116));
            temPoints.Add(new Point(622.827607175433, 213.646489104116));
            temPoints.Add(new Point(622.827607175433, 213.646489104116));
            temPoints.Add(new Point(622.827607175433, 213.646489104116));
            temPoints.Add(new Point(622.827607175433, 213.646489104116));
            temPoints.Add(new Point(622.827607175433, 213.646489104116));
            temPoints.Add(new Point(622.292490118577, 213.35593220339));
            temPoints.Add(new Point(621.222256004865, 212.774818401937));
            temPoints.Add(new Point(620.297962906659, 212.629539951574));
            temPoints.Add(new Point(618.643964730921, 212.145278450363));
            temPoints.Add(new Point(616.941319550015, 212));
            temPoints.Add(new Point(614.460322286409, 211.661016949153));
            temPoints.Add(new Point(611.73608999696, 211.612590799031));
            temPoints.Add(new Point(608.282152629979, 211.515738498789));
            temPoints.Add(new Point(604.390392216479, 211.709443099274));
            temPoints.Add(new Point(599.671632715111, 211.903147699758));
            temPoints.Add(new Point(594.563697172393, 212.43583535109));
            temPoints.Add(new Point(588.677409546975, 213.065375302663));
            temPoints.Add(new Point(582.401945880207, 213.888619854722));
            temPoints.Add(new Point(575.396777135908, 214.808716707022));
            temPoints.Add(new Point(568.099726360596, 215.970944309927));
            temPoints.Add(new Point(560.462146549103, 217.230024213075));
            temPoints.Add(new Point(552.727272727273, 218.634382566586));
            temPoints.Add(new Point(544.846457889936, 219.990314769976));
            temPoints.Add(new Point(537.111584068106, 221.394673123487));
            temPoints.Add(new Point(529.522651261782, 222.702179176755));
            temPoints.Add(new Point(522.176953481301, 224.009685230024));
            temPoints.Add(new Point(515.26907874734, 225.17191283293));
            temPoints.Add(new Point(508.701733049559, 226.140435835351));
            temPoints.Add(new Point(502.523563393129, 227.01210653753));
            temPoints.Add(new Point(496.783216783217, 227.690072639225));
            temPoints.Add(new Point(491.821222256005, 228.222760290557));
            temPoints.Add(new Point(487.297050775312, 228.416464891041));
            temPoints.Add(new Point(483.745819397993, 228.900726392252));
            temPoints.Add(new Point(480.243235025844, 228.610169491525));
            temPoints.Add(new Point(477.956825782913, 228.610169491525));
            temPoints.Add(new Point(476.1082395865, 228.319612590799));
            temPoints.Add(new Point(475.183946488294, 228.077481840194));
            temPoints.Add(new Point(533.511705685619, 181.491525423729));
            temPoints.Add(new Point(534.387351778656, 181.10411622276));
            temPoints.Add(new Point(534.387351778656, 181.10411622276));
            temPoints.Add(new Point(535.068409851018, 180.668280871671));
            temPoints.Add(new Point(535.506232897537, 180.523002421308));
            temPoints.Add(new Point(535.506232897537, 180.523002421308));
            temPoints.Add(new Point(536.041349954393, 180.61985472155));
            temPoints.Add(new Point(536.041349954393, 180.61985472155));
            temPoints.Add(new Point(536.673761021587, 181.346246973366));
            temPoints.Add(new Point(536.771055031925, 181.782082324455));
            temPoints.Add(new Point(537.306172088781, 182.750605326876));
            temPoints.Add(new Point(537.500760109456, 183.573849878935));
            temPoints.Add(new Point(538.181818181818, 185.075060532688));
            temPoints.Add(new Point(538.668288233506, 186.52784503632));
            temPoints.Add(new Point(539.592581331712, 188.513317191283));
            temPoints.Add(new Point(540.370933414412, 190.64406779661));
            temPoints.Add(new Point(541.392520522955, 193.162227602906));
            temPoints.Add(new Point(542.316813621161, 195.970944309927));
            temPoints.Add(new Point(543.387047734874, 199.118644067797));
            temPoints.Add(new Point(544.554575858924, 202.508474576271));
            temPoints.Add(new Point(545.86804499848, 206.188861985472));
            temPoints.Add(new Point(547.181514138036, 210.111380145278));
            temPoints.Add(new Point(548.786865308604, 214.421307506053));
            temPoints.Add(new Point(550.440863484342, 218.924939467312));
            temPoints.Add(new Point(552.289449680754, 223.670702179177));
            temPoints.Add(new Point(554.138035877166, 228.416464891041));
            temPoints.Add(new Point(556.035269078747, 233.259079903148));
            temPoints.Add(new Point(557.786561264822, 238.053268765133));
            temPoints.Add(new Point(559.440559440559, 242.702179176755));
            temPoints.Add(new Point(560.899969595622, 247.157384987893));
            temPoints.Add(new Point(562.018850714503, 251.322033898305));
            temPoints.Add(new Point(562.89449680754, 255.147699757869));
            temPoints.Add(new Point(563.526907874734, 258.634382566586));
            temPoints.Add(new Point(563.916083916084, 261.830508474576));
            temPoints.Add(new Point(564.256612952265, 264.639225181598));
            temPoints.Add(new Point(564.597141988446, 267.302663438257));
            temPoints.Add(new Point(564.937671024628, 269.578692493947));
            temPoints.Add(new Point(565.472788081484, 271.757869249395));
            temPoints.Add(new Point(566.00790513834, 273.549636803874));
            temPoints.Add(new Point(566.883551231377, 275.680387409201));
            temPoints.Add(new Point(567.515962298571, 277.230024213075));
            temPoints.Add(new Point(568.488902401946, 278.973365617433));
            temPoints.Add(new Point(569.12131346914, 280.329297820823));
            temPoints.Add(new Point(569.899665551839, 281.733656174334));
            strokes.Add(temPoints);
            count10++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(506.026147765278, 177.181598062954));
            temPoints.Add(new Point(505.539677713591, 177.665859564165));
            temPoints.Add(new Point(504.664031620553, 177.617433414044));
            temPoints.Add(new Point(503.885679537853, 177.520581113801));
            temPoints.Add(new Point(503.885679537853, 177.520581113801));
            temPoints.Add(new Point(502.86409242931, 177.278450363196));
            temPoints.Add(new Point(502.86409242931, 177.278450363196));
            temPoints.Add(new Point(502.231681362116, 176.745762711864));
            temPoints.Add(new Point(502.231681362116, 176.745762711864));
            temPoints.Add(new Point(501.939799331104, 176.116222760291));
            temPoints.Add(new Point(501.939799331104, 176.116222760291));
            temPoints.Add(new Point(502.572210398297, 175.63196125908));
            temPoints.Add(new Point(503.496503496503, 175.583535108959));
            temPoints.Add(new Point(504.566737610216, 175.389830508475));
            temPoints.Add(new Point(506.318029796291, 175.438256658596));
            temPoints.Add(new Point(508.409851018547, 175.389830508475));
            temPoints.Add(new Point(511.182730313165, 175.438256658596));
            temPoints.Add(new Point(514.442079659471, 175.389830508475));
            temPoints.Add(new Point(518.236546062633, 175.438256658596));
            temPoints.Add(new Point(522.420188507145, 175.389830508475));
            temPoints.Add(new Point(527.090301003345, 175.341404358353));
            temPoints.Add(new Point(532.198236546063, 175.19612590799));
            temPoints.Add(new Point(537.792642140468, 175.147699757869));
            temPoints.Add(new Point(543.776223776224, 174.905569007264));
            temPoints.Add(new Point(550.197628458498, 174.760290556901));
            temPoints.Add(new Point(556.910915171785, 174.518159806295));
            temPoints.Add(new Point(564.110671936759, 174.27602905569));
            temPoints.Add(new Point(571.553663727577, 174.033898305085));
            temPoints.Add(new Point(579.239890544238, 173.743341404358));
            temPoints.Add(new Point(586.974764366069, 173.35593220339));
            temPoints.Add(new Point(594.758285193068, 172.968523002421));
            temPoints.Add(new Point(602.347217999392, 172.581113801453));
            temPoints.Add(new Point(609.692915779872, 172.193704600484));
            temPoints.Add(new Point(616.600790513834, 171.903147699758));
            temPoints.Add(new Point(622.973548190939, 171.612590799031));
            temPoints.Add(new Point(628.616600790514, 171.418886198547));
            temPoints.Add(new Point(633.578595317726, 171.370460048426));
            temPoints.Add(new Point(637.810884767406, 171.612590799031));
            temPoints.Add(new Point(641.021587108544, 171.515738498789));
            temPoints.Add(new Point(643.745819397993, 171.903147699758));
            temPoints.Add(new Point(645.253876558224, 171.661016949153));
            temPoints.Add(new Point(646.470051687443, 171.854721549637));
            temPoints.Add(new Point(646.470051687443, 171.854721549637));
            temPoints.Add(new Point(646.907874733962, 171.56416464891));
            temPoints.Add(new Point(646.324110671937, 170.983050847458));
            temPoints.Add(new Point(559.878382487078, 132.43583535109));
            temPoints.Add(new Point(559.440559440559, 132.823244552058));
            temPoints.Add(new Point(559.440559440559, 132.823244552058));
            temPoints.Add(new Point(559.197324414716, 133.888619854722));
            temPoints.Add(new Point(558.905442383703, 134.324455205811));
            temPoints.Add(new Point(559.294618425053, 135.583535108959));
            temPoints.Add(new Point(559.391912435391, 136.600484261501));
            temPoints.Add(new Point(559.781088476741, 138.053268765133));
            temPoints.Add(new Point(560.024323502584, 139.506053268765));
            temPoints.Add(new Point(560.364852538766, 141.297820823245));
            temPoints.Add(new Point(560.705381574947, 143.186440677966));
            temPoints.Add(new Point(561.094557616297, 145.462469733656));
            temPoints.Add(new Point(561.483733657647, 147.932203389831));
            temPoints.Add(new Point(562.018850714503, 150.64406779661));
            temPoints.Add(new Point(562.408026755853, 153.598062953995));
            temPoints.Add(new Point(562.991790817878, 156.891041162228));
            temPoints.Add(new Point(563.624201885071, 160.523002421307));
            temPoints.Add(new Point(564.45120097294, 164.445520581114));
            temPoints.Add(new Point(565.278200060809, 168.610169491525));
            temPoints.Add(new Point(566.202493159015, 173.210653753027));
            temPoints.Add(new Point(567.126786257221, 178.101694915254));
            temPoints.Add(new Point(568.051079355427, 183.234866828087));
            temPoints.Add(new Point(568.926725448465, 188.707021791768));
            temPoints.Add(new Point(569.802371541502, 194.421307506053));
            temPoints.Add(new Point(570.532076619033, 200.232445520581));
            temPoints.Add(new Point(571.213134691396, 206.285714285714));
            temPoints.Add(new Point(571.748251748252, 212.338983050847));
            temPoints.Add(new Point(572.234721799939, 218.246973365617));
            temPoints.Add(new Point(572.672544846458, 223.864406779661));
            temPoints.Add(new Point(573.110367892977, 229.384987893462));
            temPoints.Add(new Point(573.499543934327, 234.421307506053));
            temPoints.Add(new Point(573.888719975677, 239.167070217918));
            temPoints.Add(new Point(574.180602006689, 243.476997578692));
            temPoints.Add(new Point(574.423837032533, 247.254237288136));
            temPoints.Add(new Point(574.52113104287, 250.64406779661));
            temPoints.Add(new Point(574.52113104287, 253.549636803874));
            temPoints.Add(new Point(574.472484037701, 256.164648910412));
            temPoints.Add(new Point(574.13195500152, 258.198547215496));
            temPoints.Add(new Point(574.034660991183, 260.474576271186));
            temPoints.Add(new Point(573.499543934327, 262.024213075061));
            temPoints.Add(new Point(573.35360291882, 263.719128329298));
            temPoints.Add(new Point(572.96442687747, 265.026634382567));
            temPoints.Add(new Point(572.915779872302, 266.52784503632));
            strokes.Add(temPoints);
            count10++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(455.96837944664, 163.186440677966));
            temPoints.Add(new Point(455.530556400122, 163.573849878935));
            temPoints.Add(new Point(455.433262389784, 164.058111380145));
            temPoints.Add(new Point(455.433262389784, 164.058111380145));
            temPoints.Add(new Point(454.80085132259, 164.639225181598));
            temPoints.Add(new Point(454.995439343265, 165.075060532688));
            temPoints.Add(new Point(454.995439343265, 165.075060532688));
            temPoints.Add(new Point(455.822438431134, 165.801452784504));
            temPoints.Add(new Point(456.35755548799, 165.946731234867));
            temPoints.Add(new Point(457.476436606871, 166.382566585956));
            temPoints.Add(new Point(458.595317725752, 166.479418886199));
            temPoints.Add(new Point(460.443903922165, 166.915254237288));
            temPoints.Add(new Point(462.341137123746, 167.060532687651));
            temPoints.Add(new Point(464.87078139252, 167.496368038741));
            temPoints.Add(new Point(467.643660687139, 167.835351089588));
            temPoints.Add(new Point(470.854363028276, 168.271186440678));
            temPoints.Add(new Point(474.405594405594, 168.658595641646));
            temPoints.Add(new Point(478.346001824263, 169.239709443099));
            temPoints.Add(new Point(482.529644268775, 169.772397094431));
            temPoints.Add(new Point(487.005168744299, 170.353510895884));
            temPoints.Add(new Point(491.821222256005, 170.886198547215));
            temPoints.Add(new Point(497.02645180906, 171.418886198547));
            temPoints.Add(new Point(502.718151413804, 171.806295399516));
            temPoints.Add(new Point(508.896321070234, 172.242130750605));
            temPoints.Add(new Point(515.415019762846, 172.629539951574));
            temPoints.Add(new Point(522.274247491639, 172.774818401937));
            temPoints.Add(new Point(529.57129826695, 172.726392251816));
            temPoints.Add(new Point(537.208878078443, 172.774818401937));
            temPoints.Add(new Point(545.08969291578, 172.532687651332));
            temPoints.Add(new Point(553.067801763454, 172.338983050847));
            temPoints.Add(new Point(561.045910611128, 172.048426150121));
            temPoints.Add(new Point(569.024019458802, 171.806295399516));
            temPoints.Add(new Point(576.807540285801, 171.467312348668));
            temPoints.Add(new Point(584.396473092125, 171.225181598063));
            temPoints.Add(new Point(591.596229857099, 171.0799031477));
            temPoints.Add(new Point(598.455457585892, 170.837772397094));
            temPoints.Add(new Point(604.828215262998, 170.740920096852));
            temPoints.Add(new Point(610.56856187291, 170.64406779661));
            temPoints.Add(new Point(615.676497415628, 170.595641646489));
            temPoints.Add(new Point(620.152021891152, 170.547215496368));
            temPoints.Add(new Point(623.946488294314, 170.547215496368));
            temPoints.Add(new Point(627.011249619945, 170.498789346247));
            temPoints.Add(new Point(629.492246883551, 170.740920096852));
            temPoints.Add(new Point(631.000304043782, 170.595641646489));
            temPoints.Add(new Point(632.313773183338, 171.128329297821));
            temPoints.Add(new Point(632.313773183338, 171.128329297821));
            temPoints.Add(new Point(632.313773183338, 171.128329297821));
            temPoints.Add(new Point(631.681362116145, 171.757869249395));
            temPoints.Add(new Point(630.465186986926, 172.096852300242));
            temPoints.Add(new Point(530.203709334144, 125.026634382567));
            temPoints.Add(new Point(529.57129826695, 125.559322033898));
            temPoints.Add(new Point(529.474004256613, 126.285714285714));
            temPoints.Add(new Point(529.230769230769, 127.01210653753));
            temPoints.Add(new Point(528.987534204926, 127.883777239709));
            temPoints.Add(new Point(528.987534204926, 129.191283292978));
            temPoints.Add(new Point(529.084828215263, 130.64406779661));
            temPoints.Add(new Point(529.328063241107, 132.532687651332));
            temPoints.Add(new Point(529.425357251444, 134.469733656174));
            temPoints.Add(new Point(529.863180297963, 136.891041162228));
            temPoints.Add(new Point(530.009121313469, 139.26392251816));
            temPoints.Add(new Point(530.641532380663, 142.266343825666));
            temPoints.Add(new Point(530.933414411675, 145.365617433414));
            temPoints.Add(new Point(531.614472484038, 148.997578692494));
            temPoints.Add(new Point(532.100942535725, 152.774818401937));
            temPoints.Add(new Point(532.733353602919, 157.036319612591));
            temPoints.Add(new Point(533.317117664944, 161.394673123487));
            temPoints.Add(new Point(533.998175737306, 166.140435835351));
            temPoints.Add(new Point(534.533292794162, 171.225181598063));
            temPoints.Add(new Point(535.262997871694, 176.794188861985));
            temPoints.Add(new Point(535.895408938887, 182.556900726392));
            temPoints.Add(new Point(536.673761021587, 188.610169491525));
            temPoints.Add(new Point(537.354819093949, 194.905569007264));
            temPoints.Add(new Point(538.133171176649, 201.588377723971));
            temPoints.Add(new Point(538.862876254181, 208.416464891041));
            temPoints.Add(new Point(539.592581331712, 215.438256658596));
            temPoints.Add(new Point(540.224992398905, 222.314769975787));
            temPoints.Add(new Point(540.711462450593, 229.094430992736));
            temPoints.Add(new Point(541.100638491943, 235.486682808717));
            temPoints.Add(new Point(541.343873517787, 241.588377723971));
            temPoints.Add(new Point(541.441167528124, 247.302663438257));
            temPoints.Add(new Point(541.343873517787, 252.242130750605));
            temPoints.Add(new Point(541.19793250228, 256.600484261501));
            temPoints.Add(new Point(540.857403466099, 260.18401937046));
            temPoints.Add(new Point(540.711462450593, 263.283292978208));
            temPoints.Add(new Point(540.127698388568, 265.317191283293));
            temPoints.Add(new Point(540.079051383399, 267.01210653753));
            temPoints.Add(new Point(539.835816357555, 267.883777239709));
            temPoints.Add(new Point(539.981757373062, 268.416464891041));
            strokes.Add(temPoints);
            count10++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(696.430525995743, 167.738498789346));
            temPoints.Add(new Point(695.214350866525, 167.690072639225));
            temPoints.Add(new Point(694.192763757981, 167.932203389831));
            temPoints.Add(new Point(692.68470659775, 167.980629539952));
            temPoints.Add(new Point(690.982061416844, 168.029055690073));
            temPoints.Add(new Point(689.376710246275, 168.319612590799));
            temPoints.Add(new Point(687.333536029188, 168.36803874092));
            temPoints.Add(new Point(685.290361812101, 168.707021791768));
            temPoints.Add(new Point(682.663423532989, 168.658595641646));
            temPoints.Add(new Point(680.231073274551, 168.949152542373));
            temPoints.Add(new Point(677.214958954089, 168.852300242131));
            temPoints.Add(new Point(674.344785649133, 169.094430992736));
            temPoints.Add(new Point(670.890848282153, 169.046004842615));
            temPoints.Add(new Point(667.436910915172, 169.239709443099));
            temPoints.Add(new Point(663.496503496503, 169.28813559322));
            temPoints.Add(new Point(659.507449072666, 169.433414043584));
            temPoints.Add(new Point(655.080571602311, 169.481840193705));
            temPoints.Add(new Point(650.507753116449, 169.72397094431));
            temPoints.Add(new Point(645.545758589237, 169.917675544794));
            temPoints.Add(new Point(640.38917604135, 170.353510895884));
            temPoints.Add(new Point(634.746123441776, 170.837772397094));
            temPoints.Add(new Point(628.859835816358, 171.418886198547));
            temPoints.Add(new Point(622.681666159927, 172));
            temPoints.Add(new Point(616.308908482821, 172.774818401937));
            temPoints.Add(new Point(609.644268774704, 173.598062953995));
            temPoints.Add(new Point(602.833688051079, 174.518159806295));
            temPoints.Add(new Point(595.82851930678, 175.438256658596));
            temPoints.Add(new Point(588.774703557312, 176.358353510896));
            temPoints.Add(new Point(581.769534813013, 177.278450363196));
            temPoints.Add(new Point(574.813013073883, 178.295399515738));
            temPoints.Add(new Point(567.905138339921, 179.312348668281));
            temPoints.Add(new Point(561.33779264214, 180.280871670702));
            temPoints.Add(new Point(555.062328975372, 181.346246973366));
            temPoints.Add(new Point(549.078747339617, 182.314769975787));
            temPoints.Add(new Point(543.484341745211, 183.283292978208));
            temPoints.Add(new Point(538.181818181818, 184.058111380145));
            temPoints.Add(new Point(533.511705685619, 185.075060532688));
            temPoints.Add(new Point(529.036181210094, 185.462469733656));
            temPoints.Add(new Point(525.582243843113, 186.334140435835));
            temPoints.Add(new Point(522.176953481301, 186.818401937046));
            temPoints.Add(new Point(519.404074186683, 187.351089588378));
            temPoints.Add(new Point(517.020370933414, 187.690072639225));
            temPoints.Add(new Point(593.396169048343, 130.305084745763));
            temPoints.Add(new Point(593.49346305868, 130.837772397094));
            temPoints.Add(new Point(593.590757069018, 131.418886198547));
            temPoints.Add(new Point(593.688051079355, 132.145278450363));
            temPoints.Add(new Point(593.88263910003, 133.162227602906));
            temPoints.Add(new Point(594.077227120705, 134.518159806295));
            temPoints.Add(new Point(594.466403162055, 136.261501210654));
            temPoints.Add(new Point(594.758285193068, 138.150121065375));
            temPoints.Add(new Point(595.293402249924, 140.377723970944));
            temPoints.Add(new Point(595.779872301611, 142.653753026634));
            temPoints.Add(new Point(596.509577379143, 145.365617433414));
            temPoints.Add(new Point(597.190635451505, 148.222760290557));
            temPoints.Add(new Point(598.066281544542, 151.467312348668));
            temPoints.Add(new Point(598.94192763758, 154.760290556901));
            temPoints.Add(new Point(599.963514746123, 158.440677966102));
            temPoints.Add(new Point(600.88780784433, 162.266343825666));
            temPoints.Add(new Point(601.909394952873, 166.285714285714));
            temPoints.Add(new Point(602.785041045911, 170.498789346247));
            temPoints.Add(new Point(603.806628154454, 174.953995157385));
            temPoints.Add(new Point(604.73092125266, 179.554479418886));
            temPoints.Add(new Point(605.801155366373, 184.203389830508));
            temPoints.Add(new Point(606.774095469748, 189.046004842615));
            temPoints.Add(new Point(607.747035573123, 193.791767554479));
            temPoints.Add(new Point(608.671328671329, 198.634382566586));
            temPoints.Add(new Point(609.595621769535, 203.573849878935));
            temPoints.Add(new Point(610.422620857403, 208.464891041162));
            temPoints.Add(new Point(611.200972940103, 213.210653753027));
            temPoints.Add(new Point(611.930678017634, 217.762711864407));
            temPoints.Add(new Point(612.563089084828, 222.169491525424));
            temPoints.Add(new Point(613.146853146853, 226.285714285714));
            temPoints.Add(new Point(613.730617208878, 230.1598062954));
            temPoints.Add(new Point(614.265734265734, 233.743341404358));
            temPoints.Add(new Point(614.80085132259, 236.98789346247));
            temPoints.Add(new Point(615.287321374278, 239.845036319613));
            temPoints.Add(new Point(615.725144420797, 242.314769975787));
            temPoints.Add(new Point(616.162967467315, 244.445520581114));
            temPoints.Add(new Point(616.552143508665, 246.237288135593));
            temPoints.Add(new Point(616.989966555184, 247.786924939467));
            temPoints.Add(new Point(617.281848586196, 248.997578692494));
            temPoints.Add(new Point(617.816965643053, 250.208232445521));
            temPoints.Add(new Point(617.816965643053, 250.692493946731));
            temPoints.Add(new Point(618.449376710246, 251.322033898305));
            temPoints.Add(new Point(618.449376710246, 251.322033898305));
            temPoints.Add(new Point(619.325022803284, 251.515738498789));
            strokes.Add(temPoints);
            count10++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            #endregion
            #region -

            name = "-";
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(404.305259957434, 236.455205811138));
            temPoints.Add(new Point(404.402553967771, 237.084745762712));
            temPoints.Add(new Point(404.402553967771, 237.084745762712));
            temPoints.Add(new Point(404.84037701429, 237.665859564165));
            temPoints.Add(new Point(405.180906050471, 238.101694915254));
            temPoints.Add(new Point(405.180906050471, 238.101694915254));
            temPoints.Add(new Point(406.348434174521, 238.585956416465));
            temPoints.Add(new Point(407.126786257221, 238.779661016949));
            temPoints.Add(new Point(408.294314381271, 239.215496368039));
            temPoints.Add(new Point(409.461842505321, 239.360774818402));
            temPoints.Add(new Point(411.018546670721, 239.74818401937));
            temPoints.Add(new Point(412.672544846458, 239.845036319613));
            temPoints.Add(new Point(414.764366068714, 240.135593220339));
            temPoints.Add(new Point(416.904834296139, 240.087167070218));
            temPoints.Add(new Point(419.531772575251, 240.18401937046));
            temPoints.Add(new Point(422.401945880207, 239.990314769976));
            temPoints.Add(new Point(425.661295226513, 239.74818401937));
            temPoints.Add(new Point(429.261173609, 239.312348668281));
            temPoints.Add(new Point(433.347522043174, 238.731234866828));
            temPoints.Add(new Point(437.725752508361, 238.004842615012));
            temPoints.Add(new Point(442.347217999392, 237.278450363196));
            temPoints.Add(new Point(447.260565521435, 236.503631961259));
            temPoints.Add(new Point(452.319854058984, 235.874092009685));
            temPoints.Add(new Point(457.379142596534, 235.244552058111));
            temPoints.Add(new Point(462.487078139252, 234.857142857143));
            temPoints.Add(new Point(467.497719671633, 234.518159806295));
            temPoints.Add(new Point(472.167832167832, 234.324455205811));
            temPoints.Add(new Point(476.448768622682, 234.324455205811));
            temPoints.Add(new Point(480.437823046519, 234.469733656174));
            temPoints.Add(new Point(483.989054423837, 234.71186440678));
            temPoints.Add(new Point(487.199756764974, 235.050847457627));
            temPoints.Add(new Point(489.972636059593, 235.486682808717));
            temPoints.Add(new Point(492.356339312861, 235.970944309927));
            temPoints.Add(new Point(494.496807540286, 236.600484261501));
            temPoints.Add(new Point(496.296746731529, 237.181598062954));
            temPoints.Add(new Point(498.19397993311, 237.956416464891));
            temPoints.Add(new Point(499.75068409851, 238.440677966102));
            temPoints.Add(new Point(501.69656430526, 239.312348668281));
            temPoints.Add(new Point(503.155974460322, 239.796610169492));
            temPoints.Add(new Point(504.712678625722, 240.426150121065));
            temPoints.Add(new Point(505.928853754941, 240.765133171913));
            strokes.Add(temPoints);
            count11++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(440.88780784433, 279.070217917676));
            temPoints.Add(new Point(440.88780784433, 279.070217917676));
            temPoints.Add(new Point(440.88780784433, 279.070217917676));
            temPoints.Add(new Point(441.325630890848, 279.409200968523));
            temPoints.Add(new Point(441.325630890848, 279.409200968523));
            temPoints.Add(new Point(441.325630890848, 279.409200968523));
            temPoints.Add(new Point(441.763453937367, 279.409200968523));
            temPoints.Add(new Point(441.763453937367, 279.409200968523));
            temPoints.Add(new Point(441.763453937367, 279.409200968523));
            temPoints.Add(new Point(441.763453937367, 279.409200968523));
            temPoints.Add(new Point(442.347217999392, 278.876513317191));
            temPoints.Add(new Point(442.785041045911, 278.779661016949));
            temPoints.Add(new Point(442.785041045911, 278.779661016949));
            temPoints.Add(new Point(443.95256916996, 278.489104116223));
            temPoints.Add(new Point(444.73092125266, 278.34382566586));
            temPoints.Add(new Point(445.995743387048, 278.440677966102));
            temPoints.Add(new Point(447.211918516266, 278.34382566586));
            temPoints.Add(new Point(449.01185770751, 278.440677966102));
            temPoints.Add(new Point(450.95773791426, 278.392251815981));
            temPoints.Add(new Point(453.390088172697, 278.489104116223));
            temPoints.Add(new Point(455.919732441472, 278.392251815981));
            temPoints.Add(new Point(458.789905746427, 278.392251815981));
            temPoints.Add(new Point(461.708726056552, 278.198547215496));
            temPoints.Add(new Point(464.773487382183, 278.053268765133));
            temPoints.Add(new Point(467.789601702645, 277.762711864407));
            temPoints.Add(new Point(470.805716023107, 277.520581113801));
            temPoints.Add(new Point(473.432654302219, 277.181598062954));
            temPoints.Add(new Point(475.865004560657, 276.842615012107));
            temPoints.Add(new Point(478.005472788081, 276.503631961259));
            temPoints.Add(new Point(480, 276.164648910412));
            temPoints.Add(new Point(481.751292186075, 275.874092009685));
            temPoints.Add(new Point(483.405290361812, 275.583535108959));
            temPoints.Add(new Point(485.059288537549, 275.389830508475));
            temPoints.Add(new Point(486.615992702949, 275.19612590799));
            temPoints.Add(new Point(488.269990878686, 275.19612590799));
            temPoints.Add(new Point(489.778048038918, 275.147699757869));
            temPoints.Add(new Point(491.577987230161, 275.438256658596));
            temPoints.Add(new Point(492.891456369717, 275.486682808717));
            temPoints.Add(new Point(494.35086652478, 275.825665859564));
            temPoints.Add(new Point(495.615688659167, 276.164648910412));
            temPoints.Add(new Point(496.491334752204, 276.406779661017));
            strokes.Add(temPoints);
            count11++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);

            #endregion
            #region *

            name = "*";
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(620.687138948009, 219.554479418886));
            temPoints.Add(new Point(620.881726968683, 218.924939467312));
            temPoints.Add(new Point(620.881726968683, 218.924939467312));
            temPoints.Add(new Point(620.881726968683, 218.924939467312));
            temPoints.Add(new Point(620.24931590149, 219.409200968523));
            temPoints.Add(new Point(619.908786865309, 220.280871670702));
            temPoints.Add(new Point(618.984493767102, 221.10411622276));
            temPoints.Add(new Point(618.060200668896, 222.46004842615));
            temPoints.Add(new Point(616.552143508665, 223.961259079903));
            temPoints.Add(new Point(614.898145332928, 226.140435835351));
            temPoints.Add(new Point(612.563089084828, 228.319612590799));
            temPoints.Add(new Point(610.130738826391, 231.128329297821));
            temPoints.Add(new Point(607.017330495591, 234.130750605327));
            temPoints.Add(new Point(603.709334144117, 237.714285714286));
            temPoints.Add(new Point(599.768926725448, 241.394673123487));
            temPoints.Add(new Point(595.585284280936, 245.510895883777));
            temPoints.Add(new Point(590.769230769231, 249.675544794189));
            temPoints.Add(new Point(585.807236242019, 254.130750605327));
            temPoints.Add(new Point(580.310124657951, 258.682808716707));
            temPoints.Add(new Point(574.618425053208, 263.476997578692));
            temPoints.Add(new Point(568.294314381271, 268.125907990315));
            temPoints.Add(new Point(562.018850714503, 272.726392251816));
            temPoints.Add(new Point(555.597446032229, 277.181598062954));
            temPoints.Add(new Point(549.370629370629, 281.588377723971));
            temPoints.Add(new Point(543.289753724536, 285.65617433414));
            temPoints.Add(new Point(537.403466099118, 289.530266343826));
            temPoints.Add(new Point(531.711766494375, 292.968523002421));
            temPoints.Add(new Point(526.409242930982, 296.164648910412));
            temPoints.Add(new Point(521.739130434783, 299.118644067797));
            temPoints.Add(new Point(517.360899969596, 301.733656174334));
            temPoints.Add(new Point(513.420492550927, 304.154963680387));
            temPoints.Add(new Point(509.723320158103, 306.188861985472));
            temPoints.Add(new Point(506.561264822134, 308.174334140436));
            temPoints.Add(new Point(503.496503496503, 309.530266343826));
            temPoints.Add(new Point(501.356035269079, 310.934624697337));
            temPoints.Add(new Point(499.36150805716, 311.903147699758));
            temPoints.Add(new Point(497.853450896929, 312.532687651332));
            temPoints.Add(new Point(506.366676801459, 232.823244552058));
            temPoints.Add(new Point(505.539677713591, 232.193704600484));
            temPoints.Add(new Point(505.004560656735, 231.709443099274));
            temPoints.Add(new Point(504.323502584372, 231.0799031477));
            temPoints.Add(new Point(504.323502584372, 231.0799031477));
            temPoints.Add(new Point(503.982973548191, 230.547215496368));
            temPoints.Add(new Point(503.982973548191, 230.547215496368));
            temPoints.Add(new Point(504.518090605047, 230.837772397094));
            temPoints.Add(new Point(505.19914867741, 231.467312348668));
            temPoints.Add(new Point(506.074794770447, 232.145278450363));
            temPoints.Add(new Point(507.339616904834, 233.162227602906));
            temPoints.Add(new Point(508.847674065065, 234.324455205811));
            temPoints.Add(new Point(510.744907266646, 235.728813559322));
            temPoints.Add(new Point(512.93402249924, 237.181598062954));
            temPoints.Add(new Point(515.366372757677, 238.779661016949));
            temPoints.Add(new Point(518.041958041958, 240.571428571429));
            temPoints.Add(new Point(521.05807236242, 242.46004842615));
            temPoints.Add(new Point(524.17148069322, 244.493946731235));
            temPoints.Add(new Point(527.479477044694, 246.624697336562));
            temPoints.Add(new Point(530.982061416844, 248.852300242131));
            temPoints.Add(new Point(534.727880814837, 251.225181598063));
            temPoints.Add(new Point(538.619641228337, 253.791767554479));
            temPoints.Add(new Point(542.75463666768, 256.55205811138));
            temPoints.Add(new Point(546.986926117361, 259.360774818402));
            temPoints.Add(new Point(551.365156582548, 262.266343825666));
            temPoints.Add(new Point(555.792034052904, 265.365617433414));
            temPoints.Add(new Point(560.364852538766, 268.658595641646));
            temPoints.Add(new Point(564.986318029796, 272));
            temPoints.Add(new Point(569.656430525996, 275.389830508475));
            temPoints.Add(new Point(574.034660991183, 278.682808716707));
            temPoints.Add(new Point(578.315597446032, 282.072639225182));
            temPoints.Add(new Point(582.450592885376, 285.268765133172));
            temPoints.Add(new Point(586.342353298875, 288.561743341404));
            temPoints.Add(new Point(589.844937671025, 291.661016949153));
            temPoints.Add(new Point(593.201581027668, 294.808716707022));
            temPoints.Add(new Point(596.071754332624, 297.859564164649));
            temPoints.Add(new Point(598.650045606567, 300.958837772397));
            temPoints.Add(new Point(600.936454849498, 303.912832929782));
            temPoints.Add(new Point(603.028276071754, 306.818401937046));
            temPoints.Add(new Point(604.828215262998, 309.530266343826));
            temPoints.Add(new Point(606.482213438735, 312.096852300242));
            temPoints.Add(new Point(607.941623593797, 314.518159806295));
            temPoints.Add(new Point(609.206445728185, 316.600484261501));
            temPoints.Add(new Point(610.422620857403, 318.440677966102));
            temPoints.Add(new Point(611.34691395561, 319.796610169492));
            temPoints.Add(new Point(612.514442079659, 321.200968523002));
            temPoints.Add(new Point(613.146853146853, 321.927360774818));
            temPoints.Add(new Point(613.973852234722, 322.363196125908));
            temPoints.Add(new Point(614.460322286409, 322.121065375303));
            temPoints.Add(new Point(614.898145332928, 321.346246973366));
            temPoints.Add(new Point(564.937671024628, 220.377723970944));
            temPoints.Add(new Point(564.353906962603, 219.554479418886));
            temPoints.Add(new Point(564.353906962603, 219.554479418886));
            temPoints.Add(new Point(564.353906962603, 219.554479418886));
            temPoints.Add(new Point(563.916083916084, 219.602905569007));
            temPoints.Add(new Point(564.013377926421, 220.232445520581));
            temPoints.Add(new Point(564.159318941928, 221.055690072639));
            temPoints.Add(new Point(564.402553967771, 222.169491525424));
            temPoints.Add(new Point(564.45120097294, 223.234866828087));
            temPoints.Add(new Point(564.694435998784, 224.542372881356));
            temPoints.Add(new Point(564.694435998784, 225.801452784504));
            temPoints.Add(new Point(564.986318029796, 227.351089588378));
            temPoints.Add(new Point(564.937671024628, 228.755447941889));
            temPoints.Add(new Point(565.180906050471, 230.498789346247));
            temPoints.Add(new Point(565.132259045302, 232.193704600484));
            temPoints.Add(new Point(565.375494071146, 234.324455205811));
            temPoints.Add(new Point(565.472788081484, 236.697336561743));
            temPoints.Add(new Point(565.764670112496, 239.506053268765));
            temPoints.Add(new Point(566.056552143509, 242.508474576271));
            temPoints.Add(new Point(566.445728184859, 245.898305084746));
            temPoints.Add(new Point(566.834904226209, 249.627118644068));
            temPoints.Add(new Point(567.272727272727, 253.694915254237));
            temPoints.Add(new Point(567.661903314077, 258.101694915254));
            temPoints.Add(new Point(567.95378534509, 262.799031476998));
            temPoints.Add(new Point(568.099726360596, 267.641646489104));
            temPoints.Add(new Point(568.099726360596, 272.581113801453));
            temPoints.Add(new Point(567.905138339921, 277.47215496368));
            temPoints.Add(new Point(567.515962298571, 282.508474576271));
            temPoints.Add(new Point(566.883551231377, 287.399515738499));
            temPoints.Add(new Point(566.056552143509, 292.532687651332));
            temPoints.Add(new Point(564.986318029796, 297.47215496368));
            temPoints.Add(new Point(563.916083916084, 302.363196125908));
            temPoints.Add(new Point(562.602614776528, 307.108958837772));
            temPoints.Add(new Point(561.386439647309, 311.854721549637));
            temPoints.Add(new Point(560.024323502584, 316.55205811138));
            temPoints.Add(new Point(558.759501368197, 321.346246973366));
            temPoints.Add(new Point(557.446032228641, 326.09200968523));
            temPoints.Add(new Point(556.473092125266, 330.64406779661));
            temPoints.Add(new Point(555.54879902706, 334.953995157385));
            temPoints.Add(new Point(554.819093949529, 338.973365617433));
            temPoints.Add(new Point(554.429917908179, 342.799031476998));
            temPoints.Add(new Point(554.040741866829, 346.188861985472));
            temPoints.Add(new Point(554.040741866829, 349.28813559322));
            temPoints.Add(new Point(553.943447856491, 351.467312348668));
            temPoints.Add(new Point(554.527211918516, 353.452784503632));
            temPoints.Add(new Point(554.624505928854, 354.518159806295));
            temPoints.Add(new Point(555.110975980541, 355.244552058111));
            temPoints.Add(new Point(555.110975980541, 355.244552058111));
            temPoints.Add(new Point(484.134995439343, 277.47215496368));
            temPoints.Add(new Point(483.162055335968, 277.036319612591));
            temPoints.Add(new Point(482.432350258437, 276.697336561743));
            temPoints.Add(new Point(481.751292186075, 276.116222760291));
            temPoints.Add(new Point(481.362116144725, 275.486682808717));
            temPoints.Add(new Point(481.264822134387, 275.050847457627));
            temPoints.Add(new Point(481.264822134387, 275.050847457627));
            temPoints.Add(new Point(481.994527211918, 274.566585956416));
            temPoints.Add(new Point(482.870173304956, 274.421307506053));
            temPoints.Add(new Point(484.086348434175, 274.421307506053));
            temPoints.Add(new Point(485.594405594406, 274.179176755448));
            temPoints.Add(new Point(487.588932806324, 274.082324455206));
            temPoints.Add(new Point(489.778048038918, 273.694915254237));
            temPoints.Add(new Point(492.453633323199, 273.404358353511));
            temPoints.Add(new Point(495.275159622986, 272.871670702179));
            temPoints.Add(new Point(498.58315597446, 272.484261501211));
            temPoints.Add(new Point(501.891152325935, 271.854721549637));
            temPoints.Add(new Point(505.734265734266, 271.515738498789));
            temPoints.Add(new Point(509.626026147765, 271.0799031477));
            temPoints.Add(new Point(513.858315597446, 270.934624697337));
            temPoints.Add(new Point(518.187899057464, 270.740920096852));
            temPoints.Add(new Point(522.760717543326, 270.789346246973));
            temPoints.Add(new Point(527.382183034357, 270.789346246973));
            temPoints.Add(new Point(532.344177561569, 271.031476997579));
            temPoints.Add(new Point(537.452113104287, 271.128329297821));
            temPoints.Add(new Point(542.657342657343, 271.273607748184));
            temPoints.Add(new Point(547.911219215567, 271.225181598063));
            temPoints.Add(new Point(553.359683794466, 271.128329297821));
            temPoints.Add(new Point(558.905442383703, 270.886198547215));
            temPoints.Add(new Point(564.743083003953, 270.450363196126));
            temPoints.Add(new Point(570.532076619033, 269.869249394673));
            temPoints.Add(new Point(576.321070234114, 269.094430992736));
            temPoints.Add(new Point(581.915475828519, 268.222760290557));
            temPoints.Add(new Point(587.509881422925, 267.254237288136));
            temPoints.Add(new Point(592.909698996655, 266.334140435835));
            temPoints.Add(new Point(598.309516570386, 265.414043583535));
            temPoints.Add(new Point(603.417452113104, 264.542372881356));
            temPoints.Add(new Point(608.136211614472, 263.864406779661));
            temPoints.Add(new Point(612.660383095166, 263.283292978208));
            temPoints.Add(new Point(616.844025539678, 262.944309927361));
            temPoints.Add(new Point(620.735785953177, 262.799031476998));
            temPoints.Add(new Point(624.287017330496, 262.799031476998));
            temPoints.Add(new Point(627.497719671633, 262.992736077482));
            temPoints.Add(new Point(630.270598966251, 263.283292978208));
            temPoints.Add(new Point(632.800243235026, 263.864406779661));
            temPoints.Add(new Point(634.697476436607, 264.300242130751));
            temPoints.Add(new Point(636.692003648525, 265.365617433414));
            temPoints.Add(new Point(637.6649437519, 266.09200968523));
            temPoints.Add(new Point(638.589236850106, 267.01210653753));
            temPoints.Add(new Point(638.783824870781, 267.690072639225));
            temPoints.Add(new Point(638.589236850106, 268.416464891041));
            strokes.Add(temPoints);
            count12++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(579.385831559745, 233.259079903148));
            temPoints.Add(new Point(579.385831559745, 233.259079903148));
            temPoints.Add(new Point(580.310124657951, 233.549636803874));
            temPoints.Add(new Point(580.310124657951, 233.549636803874));
            temPoints.Add(new Point(581.088476740651, 233.501210653753));
            temPoints.Add(new Point(581.088476740651, 233.501210653753));
            temPoints.Add(new Point(581.769534813013, 233.646489104116));
            temPoints.Add(new Point(581.769534813013, 233.646489104116));
            temPoints.Add(new Point(581.769534813013, 233.646489104116));
            temPoints.Add(new Point(582.158710854363, 234.518159806295));
            temPoints.Add(new Point(581.720887807844, 234.905569007264));
            temPoints.Add(new Point(581.429005776832, 235.825665859564));
            temPoints.Add(new Point(580.456065673457, 236.745762711864));
            temPoints.Add(new Point(579.677713590757, 238.295399515738));
            temPoints.Add(new Point(578.169656430526, 239.990314769976));
            temPoints.Add(new Point(576.661599270295, 242.363196125908));
            temPoints.Add(new Point(574.618425053208, 244.929782082324));
            temPoints.Add(new Point(572.429309820614, 248.029055690073));
            temPoints.Add(new Point(569.656430525996, 251.418886198547));
            temPoints.Add(new Point(566.640316205534, 255.292978208232));
            temPoints.Add(new Point(563.089084828215, 259.26392251816));
            temPoints.Add(new Point(559.294618425053, 263.622276029056));
            temPoints.Add(new Point(555.15962298571, 267.883777239709));
            temPoints.Add(new Point(550.927333536029, 272.242130750605));
            temPoints.Add(new Point(546.500456065673, 276.503631961259));
            temPoints.Add(new Point(542.073578595318, 280.716707021792));
            temPoints.Add(new Point(537.646701124962, 284.73607748184));
            temPoints.Add(new Point(533.268470659775, 288.561743341404));
            temPoints.Add(new Point(528.987534204926, 292.193704600484));
            temPoints.Add(new Point(524.852538765582, 295.777239709443));
            temPoints.Add(new Point(520.863484341745, 299.167070217918));
            temPoints.Add(new Point(517.069017938583, 302.508474576271));
            temPoints.Add(new Point(513.371845545759, 305.704600484262));
            temPoints.Add(new Point(509.723320158103, 308.755447941889));
            temPoints.Add(new Point(506.220735785953, 311.757869249395));
            temPoints.Add(new Point(502.961386439647, 314.518159806295));
            temPoints.Add(new Point(500.042566129523, 317.181598062954));
            temPoints.Add(new Point(497.172392824567, 319.360774818402));
            temPoints.Add(new Point(494.885983581636, 321.588377723971));
            temPoints.Add(new Point(492.259045302524, 323.138014527845));
            temPoints.Add(new Point(490.410459106111, 324.542372881356));
            temPoints.Add(new Point(488.561872909699, 325.365617433414));
            temPoints.Add(new Point(487.248403770143, 325.801452784504));
            temPoints.Add(new Point(495.275159622986, 250.595641646489));
            temPoints.Add(new Point(494.545454545455, 250.886198547215));
            temPoints.Add(new Point(494.545454545455, 250.886198547215));
            temPoints.Add(new Point(494.35086652478, 251.322033898305));
            temPoints.Add(new Point(494.35086652478, 251.322033898305));
            temPoints.Add(new Point(494.837336576467, 251.757869249395));
            temPoints.Add(new Point(495.323806628154, 252.145278450363));
            temPoints.Add(new Point(496.199452721192, 252.823244552058));
            temPoints.Add(new Point(497.172392824567, 253.404358353511));
            temPoints.Add(new Point(498.534508969292, 254.27602905569));
            temPoints.Add(new Point(499.945272119185, 255.147699757869));
            temPoints.Add(new Point(501.647917300091, 256.261501210654));
            temPoints.Add(new Point(503.301915475828, 257.326876513317));
            temPoints.Add(new Point(505.247795682578, 258.634382566586));
            temPoints.Add(new Point(507.096381878991, 259.845036319613));
            temPoints.Add(new Point(509.188203101247, 261.394673123487));
            temPoints.Add(new Point(511.328671328671, 262.89588377724));
            temPoints.Add(new Point(513.71237458194, 264.639225181598));
            temPoints.Add(new Point(516.04743083004, 266.334140435835));
            temPoints.Add(new Point(518.577075098814, 268.125907990315));
            temPoints.Add(new Point(521.204013377926, 270.111380145278));
            temPoints.Add(new Point(523.879598662207, 272.242130750605));
            temPoints.Add(new Point(526.652477956826, 274.469733656174));
            temPoints.Add(new Point(529.425357251444, 276.745762711864));
            temPoints.Add(new Point(532.149589540894, 279.118644067797));
            temPoints.Add(new Point(534.922468835512, 281.588377723971));
            temPoints.Add(new Point(537.695348130131, 284.106537530266));
            temPoints.Add(new Point(540.662815445424, 286.721549636804));
            temPoints.Add(new Point(543.678929765886, 289.28813559322));
            temPoints.Add(new Point(546.792338096686, 291.951573849879));
            temPoints.Add(new Point(549.954393432654, 294.566585956416));
            temPoints.Add(new Point(553.262389784129, 297.133171912833));
            temPoints.Add(new Point(556.424445120097, 299.699757869249));
            temPoints.Add(new Point(559.537853450897, 302.169491525424));
            temPoints.Add(new Point(562.408026755853, 304.590799031477));
            temPoints.Add(new Point(565.034965034965, 306.963680387409));
            temPoints.Add(new Point(567.370021283065, 309.239709443099));
            temPoints.Add(new Point(569.461842505321, 311.418886198547));
            temPoints.Add(new Point(571.213134691396, 313.404358353511));
            temPoints.Add(new Point(572.672544846458, 315.389830508475));
            temPoints.Add(new Point(573.986013986014, 317.230024213075));
            temPoints.Add(new Point(575.250836120401, 318.82808716707));
            temPoints.Add(new Point(576.564305259957, 320.329297820823));
            temPoints.Add(new Point(577.780480389176, 321.491525423729));
            temPoints.Add(new Point(579.19124353907, 322.653753026634));
            temPoints.Add(new Point(580.261477652782, 323.138014527845));
            temPoints.Add(new Point(581.623593797507, 323.81598062954));
            temPoints.Add(new Point(582.742474916388, 323.81598062954));
            temPoints.Add(new Point(583.958650045607, 323.767554479419));
            temPoints.Add(new Point(584.785649133475, 323.089588377724));
            temPoints.Add(new Point(538.133171176649, 240.038740920097));
            temPoints.Add(new Point(538.668288233506, 240.135593220339));
            temPoints.Add(new Point(538.668288233506, 240.135593220339));
            temPoints.Add(new Point(539.300699300699, 240.813559322034));
            temPoints.Add(new Point(539.300699300699, 240.813559322034));
            temPoints.Add(new Point(540.273639404074, 241.830508474576));
            temPoints.Add(new Point(541.100638491943, 242.702179176755));
            temPoints.Add(new Point(541.781696564305, 243.670702179177));
            temPoints.Add(new Point(542.511401641836, 244.832929782082));
            temPoints.Add(new Point(543.095165703861, 246.140435835351));
            temPoints.Add(new Point(543.484341745211, 247.496368038741));
            temPoints.Add(new Point(543.873517786561, 248.997578692494));
            temPoints.Add(new Point(543.970811796899, 250.595641646489));
            temPoints.Add(new Point(544.262693827911, 252.532687651332));
            temPoints.Add(new Point(544.262693827911, 254.372881355932));
            temPoints.Add(new Point(544.359987838249, 256.600484261501));
            temPoints.Add(new Point(544.408634843417, 258.924939467312));
            temPoints.Add(new Point(544.554575858924, 261.53995157385));
            temPoints.Add(new Point(544.505928853755, 264.348668280872));
            temPoints.Add(new Point(544.505928853755, 267.44794188862));
            temPoints.Add(new Point(544.359987838249, 270.692493946731));
            temPoints.Add(new Point(544.165399817574, 274.082324455206));
            temPoints.Add(new Point(543.727576771055, 277.665859564165));
            temPoints.Add(new Point(543.241106719368, 281.443099273608));
            temPoints.Add(new Point(542.560048647005, 285.220338983051));
            temPoints.Add(new Point(541.830343569474, 289.191283292978));
            temPoints.Add(new Point(541.003344481605, 293.113801452785));
            temPoints.Add(new Point(540.176345393737, 297.133171912833));
            temPoints.Add(new Point(539.300699300699, 301.007263922518));
            temPoints.Add(new Point(538.473700212831, 304.881355932203));
            temPoints.Add(new Point(537.743995135299, 308.464891041162));
            temPoints.Add(new Point(537.111584068106, 311.951573849879));
            temPoints.Add(new Point(536.527820006081, 315.19612590799));
            temPoints.Add(new Point(536.089996959562, 318.053268765133));
            temPoints.Add(new Point(535.749467923381, 320.668280871671));
            temPoints.Add(new Point(535.506232897537, 322.944309927361));
            temPoints.Add(new Point(535.311644876862, 324.881355932203));
            temPoints.Add(new Point(535.262997871694, 326.576271186441));
            temPoints.Add(new Point(535.262997871694, 327.980629539952));
            temPoints.Add(new Point(535.360291882031, 329.046004842615));
            temPoints.Add(new Point(535.603526907875, 329.917675544794));
            temPoints.Add(new Point(535.603526907875, 329.917675544794));
            temPoints.Add(new Point(536.430525995743, 330.692493946731));
            temPoints.Add(new Point(536.430525995743, 330.692493946731));
            temPoints.Add(new Point(537.403466099118, 329.917675544794));
            temPoints.Add(new Point(537.889936150806, 328.900726392252));
            temPoints.Add(new Point(538.570994223168, 327.690072639225));
            temPoints.Add(new Point(472.021891152326, 285.753026634383));
            temPoints.Add(new Point(471.48677409547, 285.65617433414));
            temPoints.Add(new Point(471.48677409547, 285.65617433414));
            temPoints.Add(new Point(471.48677409547, 285.65617433414));
            temPoints.Add(new Point(471.48677409547, 285.65617433414));
            temPoints.Add(new Point(472.313773183338, 285.220338983051));
            temPoints.Add(new Point(472.313773183338, 285.220338983051));
            temPoints.Add(new Point(473.432654302219, 284.784503631961));
            temPoints.Add(new Point(473.967771359076, 284.397094430993));
            temPoints.Add(new Point(474.940711462451, 284.348668280872));
            temPoints.Add(new Point(475.767710550319, 283.961259079903));
            temPoints.Add(new Point(477.129826695044, 283.961259079903));
            temPoints.Add(new Point(478.491942839769, 283.719128329298));
            temPoints.Add(new Point(480.291882031012, 283.767554479419));
            temPoints.Add(new Point(482.189115232593, 283.864406779661));
            temPoints.Add(new Point(484.329583460018, 284.154963680387));
            temPoints.Add(new Point(486.615992702949, 284.493946731235));
            temPoints.Add(new Point(489.048342961386, 284.978208232446));
            temPoints.Add(new Point(491.723928245667, 285.510895883777));
            temPoints.Add(new Point(494.448160535117, 286.140435835351));
            temPoints.Add(new Point(497.221039829735, 286.769975786925));
            temPoints.Add(new Point(500.188507145029, 287.399515738499));
            temPoints.Add(new Point(503.301915475828, 287.93220338983));
            temPoints.Add(new Point(506.755852842809, 288.36803874092));
            temPoints.Add(new Point(510.501672240803, 288.707021791768));
            temPoints.Add(new Point(514.49072666464, 288.949152542373));
            temPoints.Add(new Point(518.625722103983, 288.997578692494));
            temPoints.Add(new Point(523.052599574339, 288.997578692494));
            temPoints.Add(new Point(527.771359075707, 288.80387409201));
            temPoints.Add(new Point(532.636059592581, 288.561743341404));
            temPoints.Add(new Point(537.743995135299, 288.319612590799));
            temPoints.Add(new Point(542.900577683186, 288.029055690073));
            temPoints.Add(new Point(548.057160231073, 287.738498789346));
            temPoints.Add(new Point(553.359683794466, 287.44794188862));
            temPoints.Add(new Point(558.710854363028, 287.157384987893));
            temPoints.Add(new Point(564.207965947096, 286.818401937046));
            temPoints.Add(new Point(569.656430525996, 286.52784503632));
            temPoints.Add(new Point(575.056248099726, 286.237288135593));
            temPoints.Add(new Point(580.358771663119, 285.946731234867));
            temPoints.Add(new Point(585.564001216175, 285.607748184019));
            temPoints.Add(new Point(590.623289753725, 285.220338983051));
            temPoints.Add(new Point(595.536637275768, 284.881355932203));
            temPoints.Add(new Point(600.158102766798, 284.590799031477));
            temPoints.Add(new Point(604.439039221648, 284.300242130751));
            temPoints.Add(new Point(608.282152629979, 284.009685230024));
            temPoints.Add(new Point(611.638795986622, 283.81598062954));
            temPoints.Add(new Point(614.508969291578, 283.670702179177));
            temPoints.Add(new Point(616.844025539678, 283.525423728814));
            temPoints.Add(new Point(618.69261173609, 283.622276029056));
            temPoints.Add(new Point(619.568257829127, 283.283292978208));
            temPoints.Add(new Point(620.054727880815, 283.428571428571));
            temPoints.Add(new Point(619.519610823959, 283.331719128329));
            temPoints.Add(new Point(618.449376710246, 283.283292978208));
            temPoints.Add(new Point(616.406202493159, 282.944309927361));
            strokes.Add(temPoints);
            count12++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);

            #endregion
            #region square root

            name = "square root";
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(339.993919124354, 188.271186440678));
            temPoints.Add(new Point(339.556096077835, 188.36803874092));
            temPoints.Add(new Point(339.556096077835, 188.36803874092));
            temPoints.Add(new Point(339.556096077835, 188.36803874092));
            temPoints.Add(new Point(339.069626026148, 188.755447941889));
            temPoints.Add(new Point(339.069626026148, 188.755447941889));
            temPoints.Add(new Point(339.069626026148, 189.384987893462));
            temPoints.Add(new Point(339.215567041654, 189.917675544794));
            temPoints.Add(new Point(339.215567041654, 189.917675544794));
            temPoints.Add(new Point(339.36150805716, 191.0799031477));
            temPoints.Add(new Point(339.312861051991, 191.612590799031));
            temPoints.Add(new Point(339.507449072666, 192.581113801453));
            temPoints.Add(new Point(339.458802067498, 193.452784503632));
            temPoints.Add(new Point(339.604743083004, 194.808716707022));
            temPoints.Add(new Point(339.556096077835, 196.309927360775));
            temPoints.Add(new Point(339.653390088173, 198.295399515738));
            temPoints.Add(new Point(339.604743083004, 200.61985472155));
            temPoints.Add(new Point(339.604743083004, 203.283292978208));
            temPoints.Add(new Point(339.556096077835, 206.334140435835));
            temPoints.Add(new Point(339.507449072666, 209.675544794189));
            temPoints.Add(new Point(339.410155062329, 213.307506053269));
            temPoints.Add(new Point(339.36150805716, 217.326876513317));
            temPoints.Add(new Point(339.215567041654, 221.443099273608));
            temPoints.Add(new Point(339.166920036485, 225.801452784504));
            temPoints.Add(new Point(339.069626026148, 230.1598062954));
            temPoints.Add(new Point(339.118273031317, 234.615012106538));
            temPoints.Add(new Point(339.118273031317, 239.070217917676));
            temPoints.Add(new Point(339.264214046823, 243.573849878935));
            temPoints.Add(new Point(339.458802067498, 247.980629539952));
            temPoints.Add(new Point(339.847978108848, 252.387409200969));
            temPoints.Add(new Point(340.334448160535, 256.697336561743));
            temPoints.Add(new Point(340.966859227729, 260.910411622276));
            temPoints.Add(new Point(341.69656430526, 264.978208232446));
            temPoints.Add(new Point(342.523563393129, 268.997578692494));
            temPoints.Add(new Point(343.399209486166, 272.9200968523));
            temPoints.Add(new Point(344.372149589541, 276.697336561743));
            temPoints.Add(new Point(345.296442687747, 280.329297820823));
            temPoints.Add(new Point(346.318029796291, 283.912832929782));
            temPoints.Add(new Point(347.242322894497, 287.302663438257));
            temPoints.Add(new Point(348.117968987534, 290.64406779661));
            temPoints.Add(new Point(348.944968075403, 293.791767554479));
            temPoints.Add(new Point(349.723320158103, 296.745762711864));
            temPoints.Add(new Point(350.453025235634, 299.457627118644));
            temPoints.Add(new Point(351.134083307996, 301.927360774818));
            temPoints.Add(new Point(351.76649437519, 304.106537530266));
            temPoints.Add(new Point(352.252964426877, 305.995157384988));
            temPoints.Add(new Point(352.739434478565, 307.496368038741));
            temPoints.Add(new Point(353.128610519915, 308.658595641646));
            temPoints.Add(new Point(353.469139556096, 309.530266343826));
            temPoints.Add(new Point(353.761021587109, 310.062953995157));
            temPoints.Add(new Point(353.761021587109, 310.062953995157));
            temPoints.Add(new Point(354.344785649133, 310.062953995157));
            temPoints.Add(new Point(354.636667680146, 309.627118644068));
            temPoints.Add(new Point(354.977196716327, 308.755447941889));
            temPoints.Add(new Point(355.317725752508, 307.544794188862));
            temPoints.Add(new Point(355.65825478869, 305.995157384988));
            temPoints.Add(new Point(355.998783824871, 304.058111380145));
            temPoints.Add(new Point(356.387959866221, 301.830508474576));
            temPoints.Add(new Point(356.777135907571, 299.312348668281));
            temPoints.Add(new Point(357.117664943752, 296.55205811138));
            temPoints.Add(new Point(357.458193979933, 293.598062953995));
            temPoints.Add(new Point(357.847370021283, 290.401937046005));
            temPoints.Add(new Point(358.285193067802, 287.060532687651));
            temPoints.Add(new Point(358.72301611432, 283.622276029056));
            temPoints.Add(new Point(359.160839160839, 280.038740920097));
            temPoints.Add(new Point(359.647309212527, 276.406779661017));
            temPoints.Add(new Point(360.085132259045, 272.581113801453));
            temPoints.Add(new Point(360.571602310733, 268.707021791768));
            temPoints.Add(new Point(360.960778352083, 264.687651331719));
            temPoints.Add(new Point(361.349954393433, 260.571428571429));
            temPoints.Add(new Point(361.739130434783, 256.358353510896));
            temPoints.Add(new Point(362.22560048647, 251.951573849879));
            temPoints.Add(new Point(362.566129522651, 247.44794188862));
            temPoints.Add(new Point(363.052599574339, 242.799031476998));
            temPoints.Add(new Point(363.587716631195, 238.101694915254));
            temPoints.Add(new Point(364.122833688051, 233.307506053269));
            temPoints.Add(new Point(364.706597750076, 228.36803874092));
            temPoints.Add(new Point(365.387655822438, 223.38014527845));
            temPoints.Add(new Point(366.068713894801, 218.34382566586));
            temPoints.Add(new Point(366.652477956826, 213.307506053269));
            temPoints.Add(new Point(367.430830039526, 208.513317191283));
            temPoints.Add(new Point(368.111888111888, 203.767554479419));
            temPoints.Add(new Point(368.792946184251, 199.167070217918));
            temPoints.Add(new Point(369.474004256613, 194.857142857143));
            temPoints.Add(new Point(370.155062328975, 190.692493946731));
            temPoints.Add(new Point(370.884767406507, 186.769975786925));
            temPoints.Add(new Point(371.565825478869, 183.089588377724));
            temPoints.Add(new Point(372.198236546063, 179.699757869249));
            temPoints.Add(new Point(372.782000608088, 176.455205811138));
            temPoints.Add(new Point(373.414411675281, 173.549636803874));
            temPoints.Add(new Point(374.046822742475, 170.934624697337));
            temPoints.Add(new Point(374.6305868045, 168.513317191283));
            temPoints.Add(new Point(375.214350866525, 166.479418886199));
            temPoints.Add(new Point(375.79811492855, 164.687651331719));
            temPoints.Add(new Point(376.381878990575, 163.234866828087));
            temPoints.Add(new Point(376.916996047431, 162.121065375303));
            temPoints.Add(new Point(377.452113104287, 161.200968523002));
            temPoints.Add(new Point(377.987230161143, 160.523002421307));
            temPoints.Add(new Point(378.570994223168, 159.990314769976));
            temPoints.Add(new Point(379.203405290362, 159.699757869249));
            temPoints.Add(new Point(379.933110367893, 159.554479418886));
            temPoints.Add(new Point(380.857403466099, 159.506053268765));
            temPoints.Add(new Point(381.97628458498, 159.554479418886));
            temPoints.Add(new Point(383.289753724536, 159.651331719128));
            temPoints.Add(new Point(384.943751900274, 159.796610169492));
            temPoints.Add(new Point(386.889632107023, 160.038740920097));
            temPoints.Add(new Point(389.078747339617, 160.232445520581));
            temPoints.Add(new Point(391.65703861356, 160.523002421307));
            temPoints.Add(new Point(394.624505928854, 160.765133171913));
            temPoints.Add(new Point(398.078443295835, 161.055690072639));
            temPoints.Add(new Point(401.970203709334, 161.394673123487));
            temPoints.Add(new Point(406.348434174521, 161.782082324455));
            temPoints.Add(new Point(411.164487686227, 162.169491525424));
            temPoints.Add(new Point(416.369717239282, 162.605326876513));
            temPoints.Add(new Point(422.110063849194, 163.089588377724));
            temPoints.Add(new Point(428.385527515962, 163.573849878935));
            temPoints.Add(new Point(435.098814229249, 164.009685230024));
            temPoints.Add(new Point(442.249923989054, 164.445520581114));
            temPoints.Add(new Point(449.79020979021, 164.73607748184));
            temPoints.Add(new Point(457.865612648221, 165.026634382567));
            temPoints.Add(new Point(466.281544542414, 165.220338983051));
            temPoints.Add(new Point(475.183946488294, 165.317191283293));
            temPoints.Add(new Point(484.329583460018, 165.317191283293));
            temPoints.Add(new Point(493.669808452417, 165.365617433414));
            temPoints.Add(new Point(503.107327455154, 165.317191283293));
            temPoints.Add(new Point(512.642140468227, 165.317191283293));
            temPoints.Add(new Point(522.128306476132, 165.365617433414));
            temPoints.Add(new Point(531.5171784737, 165.414043583535));
            temPoints.Add(new Point(540.80875646093, 165.462469733656));
            temPoints.Add(new Point(549.759805411979, 165.559322033898));
            temPoints.Add(new Point(558.467619337184, 165.65617433414));
            temPoints.Add(new Point(566.78625722104, 165.704600484262));
            temPoints.Add(new Point(574.813013073883, 165.704600484262));
            temPoints.Add(new Point(582.450592885376, 165.607748184019));
            temPoints.Add(new Point(589.553055640012, 165.510895883777));
            temPoints.Add(new Point(596.120401337793, 165.268765133172));
            temPoints.Add(new Point(602.249923989054, 165.123486682809));
            temPoints.Add(new Point(607.211918516266, 164.639225181598));
            temPoints.Add(new Point(611.979325022803, 164.203389830508));
            temPoints.Add(new Point(615.676497415628, 163.38014527845));
            temPoints.Add(new Point(618.838552751596, 162.556900726392));
            strokes.Add(temPoints);
            count14++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);
            strokes.Clear();
            temPoints.Clear();
            temPoints.Add(new Point(349.82061416844, 244.009685230024));
            temPoints.Add(new Point(350.696260261478, 244.929782082324));
            temPoints.Add(new Point(350.98814229249, 245.414043583535));
            temPoints.Add(new Point(351.37731833384, 245.995157384988));
            temPoints.Add(new Point(351.717847370021, 246.721549636804));
            temPoints.Add(new Point(351.863788385527, 247.302663438257));
            temPoints.Add(new Point(352.252964426877, 248.174334140436));
            temPoints.Add(new Point(352.447552447552, 248.997578692494));
            temPoints.Add(new Point(352.836728488902, 250.111380145278));
            temPoints.Add(new Point(352.982669504409, 251.176755447942));
            temPoints.Add(new Point(353.517786561265, 252.629539951574));
            temPoints.Add(new Point(353.858315597446, 254.082324455206));
            temPoints.Add(new Point(354.588020674977, 255.922518159806));
            temPoints.Add(new Point(355.26907874734, 257.90799031477));
            temPoints.Add(new Point(356.290665855883, 260.329297820823));
            temPoints.Add(new Point(357.312252964427, 262.89588377724));
            temPoints.Add(new Point(358.528428093645, 265.801452784504));
            temPoints.Add(new Point(359.695956217695, 268.900726392252));
            temPoints.Add(new Point(360.912131346914, 272.193704600484));
            temPoints.Add(new Point(362.128306476133, 275.63196125908));
            temPoints.Add(new Point(363.295834600182, 279.360774818402));
            temPoints.Add(new Point(364.414715719064, 283.138014527845));
            temPoints.Add(new Point(365.533596837945, 287.060532687651));
            temPoints.Add(new Point(366.603830951657, 291.031476997579));
            temPoints.Add(new Point(367.820006080876, 295.002421307506));
            temPoints.Add(new Point(369.084828215263, 298.973365617433));
            temPoints.Add(new Point(370.544238370325, 302.89588377724));
            temPoints.Add(new Point(372.003648525388, 306.673123486683));
            temPoints.Add(new Point(373.754940711462, 310.305084745763));
            temPoints.Add(new Point(375.652173913043, 313.743341404358));
            temPoints.Add(new Point(377.646701124962, 317.036319612591));
            temPoints.Add(new Point(379.64122833688, 320.135593220339));
            temPoints.Add(new Point(381.58710854363, 323.138014527845));
            temPoints.Add(new Point(383.435694740043, 325.849878934625));
            temPoints.Add(new Point(385.08969291578, 328.416464891041));
            temPoints.Add(new Point(386.597750076011, 330.740920096852));
            temPoints.Add(new Point(387.81392520523, 332.823244552058));
            temPoints.Add(new Point(388.835512313773, 334.615012106538));
            temPoints.Add(new Point(389.613864396473, 336.116222760291));
            temPoints.Add(new Point(390.197628458498, 337.326876513317));
            temPoints.Add(new Point(390.684098510185, 338.198547215496));
            temPoints.Add(new Point(391.073274551535, 338.779661016949));
            temPoints.Add(new Point(391.073274551535, 338.779661016949));
            temPoints.Add(new Point(391.559744603223, 339.118644067797));
            temPoints.Add(new Point(391.559744603223, 339.118644067797));
            temPoints.Add(new Point(391.705685618729, 338.198547215496));
            temPoints.Add(new Point(391.65703861356, 337.278450363196));
            temPoints.Add(new Point(391.511097598054, 335.970944309927));
            temPoints.Add(new Point(391.316509577379, 334.27602905569));
            temPoints.Add(new Point(391.024627546367, 332.193704600484));
            temPoints.Add(new Point(390.684098510185, 329.772397094431));
            temPoints.Add(new Point(390.294922468835, 327.060532687651));
            temPoints.Add(new Point(389.857099422317, 324.058111380145));
            temPoints.Add(new Point(389.467923380967, 320.716707021792));
            temPoints.Add(new Point(389.078747339617, 317.133171912833));
            temPoints.Add(new Point(388.786865308604, 313.162227602906));
            temPoints.Add(new Point(388.543630282761, 308.949152542373));
            temPoints.Add(new Point(388.446336272423, 304.445520581114));
            temPoints.Add(new Point(388.446336272423, 299.74818401937));
            temPoints.Add(new Point(388.592277287929, 294.905569007264));
            temPoints.Add(new Point(388.786865308604, 289.917675544794));
            temPoints.Add(new Point(389.078747339617, 284.784503631961));
            temPoints.Add(new Point(389.370629370629, 279.602905569007));
            temPoints.Add(new Point(389.711158406811, 274.421307506053));
            temPoints.Add(new Point(390.051687442992, 269.336561743341));
            temPoints.Add(new Point(390.392216479173, 264.397094430993));
            temPoints.Add(new Point(390.732745515354, 259.506053268765));
            temPoints.Add(new Point(391.073274551535, 254.615012106538));
            temPoints.Add(new Point(391.365156582548, 249.820823244552));
            temPoints.Add(new Point(391.65703861356, 245.123486682809));
            temPoints.Add(new Point(391.948920644573, 240.571428571429));
            temPoints.Add(new Point(392.192155670417, 236.213075060533));
            temPoints.Add(new Point(392.484037701429, 231.951573849879));
            temPoints.Add(new Point(392.775919732441, 227.883777239709));
            temPoints.Add(new Point(393.067801763454, 224.009685230024));
            temPoints.Add(new Point(393.359683794466, 220.280871670702));
            temPoints.Add(new Point(393.651565825479, 216.842615012107));
            temPoints.Add(new Point(393.99209486166, 213.598062953995));
            temPoints.Add(new Point(394.283976892673, 210.692493946731));
            temPoints.Add(new Point(394.624505928854, 207.980629539952));
            temPoints.Add(new Point(395.013681970204, 205.607748184019));
            temPoints.Add(new Point(395.354211006385, 203.476997578692));
            temPoints.Add(new Point(395.743387047735, 201.53995157385));
            temPoints.Add(new Point(396.132563089085, 199.941888619855));
            temPoints.Add(new Point(396.570386135603, 198.585956416465));
            temPoints.Add(new Point(396.959562176953, 197.569007263923));
            temPoints.Add(new Point(397.348738218303, 196.697336561743));
            temPoints.Add(new Point(397.786561264822, 196.067796610169));
            temPoints.Add(new Point(398.224384311341, 195.63196125908));
            temPoints.Add(new Point(398.710854363028, 195.341404358353));
            temPoints.Add(new Point(399.245971419884, 195.19612590799));
            temPoints.Add(new Point(399.878382487078, 195.244552058111));
            temPoints.Add(new Point(400.608087564609, 195.389830508475));
            temPoints.Add(new Point(401.532380662815, 195.63196125908));
            temPoints.Add(new Point(402.748555792034, 195.970944309927));
            temPoints.Add(new Point(404.06202493159, 196.358353510896));
            temPoints.Add(new Point(405.861964122834, 196.842615012107));
            temPoints.Add(new Point(407.905138339921, 197.326876513317));
            temPoints.Add(new Point(410.240194588021, 197.90799031477));
            temPoints.Add(new Point(412.915779872302, 198.392251815981));
            temPoints.Add(new Point(415.980541197933, 198.973365617433));
            temPoints.Add(new Point(419.239890544238, 199.554479418886));
            temPoints.Add(new Point(422.839768926725, 200.087167070218));
            temPoints.Add(new Point(426.780176345394, 200.668280871671));
            temPoints.Add(new Point(431.207053815749, 201.249394673124));
            temPoints.Add(new Point(435.974460322286, 201.685230024213));
            temPoints.Add(new Point(441.228336880511, 202.169491525424));
            temPoints.Add(new Point(446.822742474916, 202.605326876513));
            temPoints.Add(new Point(452.952265126178, 202.992736077482));
            temPoints.Add(new Point(459.568257829127, 203.331719128329));
            temPoints.Add(new Point(466.573426573427, 203.670702179177));
            temPoints.Add(new Point(473.821830343569, 203.81598062954));
            temPoints.Add(new Point(481.216175129219, 204.009685230024));
            temPoints.Add(new Point(488.805107935543, 204.203389830508));
            temPoints.Add(new Point(496.491334752204, 204.397094430993));
            temPoints.Add(new Point(504.274855579203, 204.590799031477));
            temPoints.Add(new Point(512.107023411371, 204.73607748184));
            temPoints.Add(new Point(519.939191243539, 204.881355932203));
            temPoints.Add(new Point(527.917300091213, 204.978208232446));
            temPoints.Add(new Point(536.089996959562, 205.123486682809));
            temPoints.Add(new Point(544.408634843417, 205.17191283293));
            temPoints.Add(new Point(552.921860747948, 205.17191283293));
            temPoints.Add(new Point(561.581027667984, 205.17191283293));
            temPoints.Add(new Point(570.386135603527, 205.123486682809));
            temPoints.Add(new Point(579.19124353907, 205.075060532688));
            temPoints.Add(new Point(587.947704469444, 205.026634382567));
            temPoints.Add(new Point(596.509577379143, 205.075060532688));
            temPoints.Add(new Point(604.828215262998, 205.17191283293));
            temPoints.Add(new Point(612.806324110672, 205.414043583535));
            temPoints.Add(new Point(620.24931590149, 205.65617433414));
            temPoints.Add(new Point(627.254484645789, 205.995157384988));
            temPoints.Add(new Point(633.578595317726, 206.430992736077));
            temPoints.Add(new Point(639.416235937975, 206.818401937046));
            temPoints.Add(new Point(644.524171480693, 207.302663438257));
            temPoints.Add(new Point(649.048342961386, 207.593220338983));
            temPoints.Add(new Point(653.086044390392, 208.029055690073));
            temPoints.Add(new Point(656.199452721192, 208.029055690073));
            temPoints.Add(new Point(659.312861051991, 208.464891041162));
            temPoints.Add(new Point(661.30738826391, 208.36803874092));
            temPoints.Add(new Point(663.058680449985, 208.36803874092));
            temPoints.Add(new Point(663.982973548191, 207.980629539952));
            strokes.Add(temPoints);
            count14++;
            multistroke = new Multistroke(name, useBoundedRotationInvariance, strokes);
            multistrokes.Add(multistroke);

            #endregion

            //No gestures are saved as mulitstrokes
            textBlock1.Text = ">>>" + count0 + " samples are saved per sympol 0\n>>>" + count1 + " samples are saved per sympol 1\n>>>" + count2 + " samples are saved per sympol 2\n>>>" + count3 + " samples are saved per sympol 3\n>>>" + count4 + " samples are saved per sympol 4\n>>>" + count5 + " samples are saved per sympol 5\n>>>" + count6 + " samples are saved per sympol 6\n>>>" + count7 + " samples are saved per sympol 7\n>>>" + count8 + " samples are saved per sympol 8\n>>>" + count9 + " samples are saved per sympol 9\n>>>" + count10 + " samples are saved per sympol +\n>>>" + count11 + " samples are saved per sympol -\n>>>" + count12 + " samples are saved per sympol *\n>>>" + count14 + " samples are saved per sympol sqrt";

        }

        #region Scratch Out Gesture

        ///Scratch out feature using Gestures
        private void onGesture(object sender, InkCanvasGestureEventArgs e)
        {
            StrokeCollection hitStrokes = Notes.Strokes.HitTest(e.Strokes.GetBounds(), 10);
            Notes.Strokes.Remove(hitStrokes);
        }

        #endregion

        #region Converting Strokes to points

        //Converting all strokes to points
        private List<List<Point>> strokesPoints(StrokeCollection strokes)
        {
            List<List<Point>> strokesPointsAll = new List<List<Point>>();
            foreach (Stroke stroke in strokes)
            {
                StylusPointCollection colStylusPoints = stroke.StylusPoints;
                List<Point> AllPoints = new List<Point>();
                foreach (StylusPoint oPoint in colStylusPoints)
                {
                    AllPoints.Add((Point)oPoint);
                }

                strokesPointsAll.Add(AllPoints);
                
            }
            return strokesPointsAll;
        }

        #endregion

        #region Color selection

        // Give the selection the Pen color.
        private void cboPenColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Notes == null) return;
            //Check if it is a Pen or Highlighter
            if (Notes.DefaultDrawingAttributes.StylusTip == StylusTip.Rectangle) return;
            if (e.AddedItems.Count < 1) return;
            ComboBoxItem item = (ComboBoxItem)e.AddedItems[0];
            //The selected color
            string value = item.Content.ToString();
            switch (value)
            {
                case "Black":
                    Notes.DefaultDrawingAttributes.Color = Colors.Black;
                    break;
                case "Red":
                    Notes.DefaultDrawingAttributes.Color = Colors.Red;
                    break;
                case "Green":
                    Notes.DefaultDrawingAttributes.Color = Colors.Green;
                    break;
                case "Blue":
                    Notes.DefaultDrawingAttributes.Color = Colors.Blue;
                    break;
                case "Purple":
                    Notes.DefaultDrawingAttributes.Color = Colors.Purple;
                    break;
            }
        }

        // Give the selection the chosen Highlighter Color.
        private void cboHighlighterColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Notes == null) return;
            //Check if it is a Pen or Highlighter
            if (Notes.DefaultDrawingAttributes.StylusTip != StylusTip.Rectangle) return;
            if (e.AddedItems.Count < 1) return;
            ComboBoxItem item = (ComboBoxItem)e.AddedItems[0];
            //The selected color
            string value = item.Content.ToString();
            switch (value)
            {
                case "Black":
                    Notes.DefaultDrawingAttributes.Color = Colors.Black;
                    break;
                case "Green":
                    Notes.DefaultDrawingAttributes.Color = Colors.Green;
                    break;
                case "Purple":
                    Notes.DefaultDrawingAttributes.Color = Colors.Purple;
                    break;
            }
        }

        #endregion

        #region Editing Selection Mode

        // Give the selection the chosen Pen or Highlighter or Eraser or Selection Mode or Scribbling Gesture.
        private void cboEditing_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Notes == null) return;
            //Set Pen and Highlighter Colors to black each time the editing mode is changed
            cboPenColor.SelectedIndex = 0;
            cboHighlighterColor.SelectedIndex = 0;
            //By Default set the editing mode to Ink
            Notes.EditingMode = InkCanvasEditingMode.Ink;
            if (e.AddedItems.Count < 1) return;
            ComboBoxItem item = (ComboBoxItem)e.AddedItems[0];
            //The selected editing mode
            string value = item.Content.ToString();
            switch (value)
            {
                case "Pen":
                    // Set up the DrawingAttributes for the pen.
                    Notes.EditingMode = InkCanvasEditingMode.Ink;
                    DrawingAttributes penDA;
                    penDA = new DrawingAttributes();
                    penDA.FitToCurve = false;
                    Notes.DefaultDrawingAttributes = penDA;
                    textBox1.Text = "Ink Mode";
                    break;
                case "Highlighter":
                    // Set up the DrawingAttributes for the highlighter.
                    Notes.EditingMode = InkCanvasEditingMode.Ink;
                    DrawingAttributes highlighterDA;
                    highlighterDA = new DrawingAttributes();
                    highlighterDA.IsHighlighter = true;
                    highlighterDA.IgnorePressure = true;
                    highlighterDA.StylusTip = StylusTip.Rectangle;
                    highlighterDA.Height = 30;
                    highlighterDA.Width = 10;
                    Notes.DefaultDrawingAttributes = highlighterDA;
                    textBox1.Text = "Ink Mode";
                    break;
                case "Erase by Stroke":
                    Notes.EditingMode = InkCanvasEditingMode.EraseByStroke;
                    textBox1.Text = "Erase by Stroke Mode";
                    break;
                case "Erase by Point":
                    Notes.EditingMode = InkCanvasEditingMode.EraseByPoint;
                    textBox1.Text = "Erase by Point Mode";
                    break;
                case "Selection Mode":
                    Notes.EditingMode = InkCanvasEditingMode.Select;
                    textBox1.Text = "Selection Mode";
                    break;
                case "Scribbling Gesture":
                    Notes.EditingMode = InkCanvasEditingMode.GestureOnly;
                    //Enable the scratchout gesture and call the function for dleeting strokes and shapes
                    Notes.Gesture += new InkCanvasGestureEventHandler(onGesture);
                    Notes.SetEnabledGestures(new ApplicationGesture[] { ApplicationGesture.ScratchOut });
                    //Display a message telling it is Scribbling Gesture mode
                    textBox1.Text = "Scribbling Gesture Mode";
                    break;
            }
        }

        #endregion

        #region Load and Save Notes

        // Load Notes (ISF files).
        private void mnuFileOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.CheckFileExists = true;
            dlg.Filter = "Ink Serialized Format (*.isf)|*.isf|" +
                         "All files (*.*)|*.*";

            if ((bool)dlg.ShowDialog(this))
            {
                this.Notes.Strokes.Clear();

                try
                {
                    using (FileStream file = new FileStream(dlg.FileName,
                                                FileMode.Open, FileAccess.Read))
                    {
                        if (!dlg.FileName.ToLower().EndsWith(".isf"))
                        {
                            MessageBox.Show("The requested file is not a Ink Serialized Format file\r\n\r\nplease retry", Title);
                        }
                        else
                        {
                            Notes.Strokes = new StrokeCollection(file);
                            file.Close();
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, Title);
                }
            }
        }


        // Save Notes as ISF file.
        private void mnuFileSave_Click(object sender, RoutedEventArgs e)
        {
            // Get the file name.
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = ".isf";
            dlg.Filter = "Ink Serialized Format (*.isf)|*.isf|" +
                         "All files (*.*)|*.*";

            if (dlg.ShowDialog() == true)
            {
                using (FileStream file = new FileStream(dlg.FileName,
                                            FileMode.Create, FileAccess.Write))
                    try
                    {
                        Notes.Strokes.Save(file); // Save.
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,
                            "Error Saving File",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error);
                    }
                    finally
                    {
                        file.Close();
                    }
            }
        }

        #endregion

        #region Clear InkCanvas and Close the program

        //Clear the window from all strokes and shapes and times
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            Notes.Strokes.Clear();
            Notes.Children.Clear();
        }

        //Close the application
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        #endregion

        #region Recognize Sympol and solve equation

        private void recgnoizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (Notes.Strokes.Count == 0)
            {
                textBox1.Text = "InkCanvas is empty";
            }
            else if (multistrokes.Count == 0)
            {
                textBox1.Text = "There are no saved templates";
            }
            else
            {
                StrokeCollection tempSC = new StrokeCollection();
                //Create dictionary to know the location for + and *
                Dictionary<string, Rect> DicSympols = new Dictionary<string, Rect>();
                StrokeCollection otherTempSC = new StrokeCollection();
                StrokeCollection sc = new StrokeCollection();
                List<int> numbers = new List<int>();
                List<string> sympolList = new List<string>();
                int dicCounter = 0;
                //Dummy value so it will not throw "out of index" exception
                sympolList.Add("dummy");
                //Check if the strokes that are drawn are multiple strokes or single stroke
                for (int i = 0; i < Notes.Strokes.Count; i++)
                {
                    for (int j = 0; j < Notes.Strokes.Count; j++)
                    {
                        //Make sure that we dont check if the stroke intersects with itself
                        if (i != j)
                        {
                            if (strokesIntersection(Notes.Strokes[i], Notes.Strokes[j])==true)
                            {
                                tempSC.Add(Notes.Strokes[i]);
                                //Save a copy
                                otherTempSC.Add(Notes.Strokes[i]);
                                break;
                            }
                        }

                    }
                    if (tempSC.Count == 0)
                    {
                        //process "+"
                        if (otherTempSC.Count == 2)
                        {
                            sympolList.Add(recognize(otherTempSC));
                            DicSympols[recognize(otherTempSC) + dicCounter] = otherTempSC.GetBounds();
                            dicCounter++;
                            otherTempSC.Clear();
                        }
                        sc.Add(Notes.Strokes[i]);
                        String name = recognize(sc);
                        if (sympolList.Last() == name && name == "-")
                        {
                            //Replace last sympol with "=", becasue the last two will be "-" "-" and they will be converted to "="
                            sympolList.Insert(sympolList.Count - 1,"=");
                            break;
                        }
                        sympolList.Add(name);
                        //Save the box bound for each strokecollection with it is key (name + location)
                        DicSympols[name + dicCounter] = sc.GetBounds();
                        dicCounter++;
                        sympolList.Remove("dummy");
                        sc.Clear();
                    }
                    else
                    {
                        //process "*"
                        if (otherTempSC.Count == 4)
                        {
                            sympolList.Add(recognize(otherTempSC));
                            DicSympols[recognize(otherTempSC) + dicCounter] = otherTempSC.GetBounds();
                            dicCounter++;
                            otherTempSC.Clear();
                        }
                        tempSC.Clear();
                    }

                }
                
                //Remove last sympol that was replaced with "=" (it was "-")
                sympolList.RemoveAt(sympolList.Count - 1);
                int counter = 0;
                string temp;
                int countTemp = -1;
                string equation = null;
                String recognizedSympols = null;
                List<string> recognizedSympols1 = new List<string>();
                List<string> pow;
                List<string> equation1 = new List<string>();
                int tempCounter = 0;
                string keys = null;
                List<string> fraction = new List<string>();
                //process fraction
                foreach (String recognizedSympol in sympolList)
                {
                    if (recognizedSympol == "-")
                    {
                        fraction = fractionProcess(recognizedSympol + counter, DicSympols, sympolList);
                        if (fraction.Count != 0)
                        {
                            equation1.Add(fraction[1]);
                            recognizedSympols1.Add(fraction[0]);
                            keys = fraction[2];
                        }
                    }
                    counter++;
                }
                counter = 0;
                foreach (String recognizedSympol in sympolList)
                {
                    //There are fractions
                    if (keys != null)
                    {

                        if (keys.IndexOf(recognizedSympol + counter) != -1)
                        {
                            counter++;
                            continue;
                        }
                    }
                   
                    //process pow
                    if (recognizedSympol != "=")
                    {
                        tempCounter = counter + 1;
                        pow = equationWithPow(recognizedSympol + counter, sympolList[tempCounter] + tempCounter, DicSympols, sympolList, recognizedSympol, tempCounter);
                        if (pow != null)
                        {
                            //There is a fraction
                            if (pow.Count == 4)
                            {
                                equation1.Add(Convert.ToString(powValue(pow[0], Convert.ToString(EvaluateExpression(pow[2])))));
                            }
                            //There is a square root value
                            else if (pow.Count == 3)
                            {
                                String sqrRootValue = Convert.ToString(sqaureRootValue(pow[2]));
                                equation1.Add(Convert.ToString(powValue(pow[0], sqrRootValue)));
                            }
                            else
                            {
                                equation1.Add(Convert.ToString(powValue(pow[0], pow[1])));
                            }
                            recognizedSympols1.Add("pow(" + pow[0] + "," + pow[1] + ")");
                            if (pow[0].Count() > 1)
                            {
                                //dectect all numbers that are under the pow
                                int j = counter - 1;
                                for (int i = 0; i < counter; i++)
                                {
                                    if (i == (pow[0].Count() - 1))
                                    {
                                        break;
                                    }
                                    equation1.RemoveAt(j);
                                    recognizedSympols1.RemoveAt(j);
                                    j--;
                                }
                            }
                            //To not include the Pow value in our output twice
                            countTemp = counter + (pow.Count - 1);
                            pow = null;
                        }
                    }
                    //process square root
                    if (recognizedSympol == "square root" && countTemp < counter)
                    {
                        temp = sqaureRoot(recognizedSympol + counter, DicSympols, sympolList);
                        if (temp == null)
                        {
                            recognizedSympols = "There is no value under Sqrt";
                            break;
                        }
                        recognizedSympols1.Add("Sqrt(" + temp + ")");
                        //solve the sqaureRootValue
                        equation1.Add(Convert.ToString(sqaureRootValue(temp)));
                        //To not include the Sqrt value in our output twice
                        countTemp = counter + temp.Count();
                        temp = null;
                    }
                    else
                    {
                        //To not include the Sqrt value in our output twice
                        if (countTemp < counter)
                        {
                            recognizedSympols1.Add(recognizedSympol);
                            if (recognizedSympol != "=")
                            {
                                //Save a copy
                                equation1.Add(recognizedSympol);
                            }
                        }
                    }
                    counter++;
                }
                //Get the equation
                foreach (string s in equation1)
                {
                    equation += s;
                }
                Console.WriteLine(equation);
                //Evaluate the equation
                recognizedSympols1.Add(EvaluateExpression(equation).ToString()); 
                foreach (string s in recognizedSympols1)
                {
                    recognizedSympols += s;
                }
                //Output the result
                textBox1.Text = recognizedSympols;
            }
        }


        #region process fractions

        private List<string> fractionProcess(String key, Dictionary<string, Rect> DicSympols, List<string> sympolList)
        {
            //Save a copy
            Rect rect = DicSympols[key];
            int counter = 0;
            string denominator = null;
            string numerator = null;
            string denominatorEqu = null;
            string numeratorEqu = null;
            string keys = null;
            List<string> newFraction = new List<string>();
            List<string> fraction = new List<string>();

            foreach (String recognizedSympol in sympolList)
            {
                if (recognizedSympol == "=")
                {
                    break;
                }
                //If the the left side of the sympol is bigger than the left side of the - and the right side of the - is bigger than the right side of sympol then that is fraction
                if (DicSympols[recognizedSympol + counter].Left > rect.Left && DicSympols[recognizedSympol + counter].Right < rect.Right && ((recognizedSympol + counter) != key))
                {
                    rect.Height = 200;
                    //First time only
                    if (keys == null)
                    {
                        keys += key + ",";
                    }
                    if (rect.Contains(DicSympols[recognizedSympol + counter]))
                    {

                        if (recognizedSympol != "+" && recognizedSympol != "-" && recognizedSympol != "*" && recognizedSympol != "square root")
                        {
                            denominator += recognizedSympol;
                            denominatorEqu += recognizedSympol + ".0";
                        }
                        else
                        {
                            denominator += recognizedSympol;
                            denominatorEqu += recognizedSympol;
                        }
                        
                    }
                    else
                    {
                        if (recognizedSympol != "+" && recognizedSympol != "-" && recognizedSympol != "*" && recognizedSympol != "square root")
                        {
                            numerator += recognizedSympol;
                            numeratorEqu += recognizedSympol + ".0";
                        }
                        else
                        {
                            numerator += recognizedSympol;
                            numeratorEqu += recognizedSympol;
                        }
                    }
                    keys += recognizedSympol + counter + ",";
                }
                counter++;
            }
            if (numerator != null && denominator != null)
            {
                fraction.Add("(" + numerator + ")/" + "(" + denominator + ")");
                fraction.Add("(" + numeratorEqu + ")/" + "(" + denominatorEqu + ")");
                fraction.Add(keys);
                return fraction;
            }
            return fraction;
        }

        #endregion

        #region process Pow Values
        //Get pow expression
        private List<string> equationWithPow(string key1, string key2, Dictionary<string, Rect> DicSympols, List<string> sympolList, String recognizedSympol, int tempCounter)
        {
            Point TopRight = new Point();
            Point BottomLeft = new Point();
            List<string> result = new List<string>();
            //Find the distance between topright corner and bottomleft corner
            TopRight = DicSympols[key1].TopRight;
            //When "="/"*"/"-"/"+" and  is found then set result as null
            if (sympolList[tempCounter] == "=" || sympolList[tempCounter] == "+" || sympolList[tempCounter] == "*" || recognizedSympol == "square root" || recognizedSympol == "=" || recognizedSympol == "+" || recognizedSympol == "*" || recognizedSympol == "-")
            {
                result = null;
            }
            else
            {
                BottomLeft = DicSympols[key2].BottomLeft;
                if (Distance(TopRight, BottomLeft) < 31)
                {
                    string num1 = null;
                    //dectect all numbers that are under the pow
                    int j = tempCounter - 1;
                    for (int i = 0; i < tempCounter; i++)
                    {
                        if (sympolList[j] == "-" || sympolList[j] == "+" || sympolList[j] == "*")
                        {
                            break;
                        }
                        num1 += sympolList[j];
                        j--; 
                    }
                    //Revers the order
                    string numTemp = null;
                    j = num1.Count() - 1;
                    for (int i = 0; i < num1.Count(); i++)
                    {
                        numTemp += num1[j];
                        j--;
                    }
                    num1 = numTemp;
                    result.Add(num1);
                    string num2 = null;
                    string num3 = null;
                    if (sympolList[tempCounter] == "square root")
                    {
                        //process the sqaureRootValue
                        num2 = ("Sqrt(" + sqaureRoot(key2, DicSympols, sympolList) + ")");
                        num3 = sqaureRoot(key2, DicSympols, sympolList);
                        
                    } else if (sympolList[tempCounter] == "-")
                    {
                        List<string> fraction = new List<string>();
                        //it will be fraction for sure
                        fraction = fractionProcess(key2, DicSympols, sympolList);
                        num2 = fraction[0];
                        num3 = fraction[1];
                        //there will be three sympols
                        result.Add(num2);
                        result.Add(num3);
                    }
                    else
                    {
                        num2 = sympolList[tempCounter];
                    }
                    result.Add(num2);
                    if (sympolList[tempCounter] == "square root")
                    {
                        result.Add(num3);
                    }
                }
                else
                {
                    result = null;
                }
            }
            return result;    
        }

        //Distance between two points
        public static double Distance(Point p1, Point p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        //Get powValue
        private double powValue(string num1,string num2)
        {
            return Math.Pow(Convert.ToDouble(num1), Convert.ToDouble(num2));
        }

        #endregion

        #region Evaluate Equation

        //Evaluate equation using dynamic code generation and compilation
        public static double EvaluateExpression(string expression)
        {
            string code = string.Format
            (
                "public static class Func{{ public static double func(){{ return {0};}}}}",
                expression
            );

            CompilerResults compilerResults = CompileScript(code);

            if (compilerResults.Errors.HasErrors)
            {
                throw new InvalidOperationException("Expression has a syntax error.");
            }

            Assembly assembly = compilerResults.CompiledAssembly;
            MethodInfo method = assembly.GetType("Func").GetMethod("func");

            return (double)method.Invoke(null, null);
        }

        public static CompilerResults CompileScript(string source)
        {
            CompilerParameters parms = new CompilerParameters();

            parms.GenerateExecutable = false;
            parms.GenerateInMemory = true;
            parms.IncludeDebugInformation = false;

            CodeDomProvider compiler = CSharpCodeProvider.CreateProvider("CSharp");

            return compiler.CompileAssemblyFromSource(parms, source);
        }

        #endregion

        #region process square root

        //process square root
        private string sqaureRoot(string key, Dictionary<string, Rect> DicSympols, List<string> sympolList)
        {
            Rect rect = DicSympols[key];
            int count = 0;
            String sqaureRootProcess = null;
            foreach (String recognizedSympolTemp in sympolList)
            {
                //Break out if reached before the end, becasue we dont want to include "="
                if (count == (DicSympols.Count - 1))
                {
                    break;
                }
                //Ignore checking the bounding box for the sympol with itself
                if ((recognizedSympolTemp + count) == (key))
                {
                    count++;
                    continue;
                }
                if (rect.Contains(DicSympols[recognizedSympolTemp + count]))
                {
                    sqaureRootProcess += recognizedSympolTemp;
                }
                count++;
            }
            return sqaureRootProcess;
        }

        //Get square root value
        private double sqaureRootValue(string equation)
        {
            return Math.Sqrt(EvaluateExpression(equation));
        }

        #endregion

        #region NDollarRecognizer

        //Calling NDollarRecognizer
        private String recognize(StrokeCollection sc)
        {
            String name = "Input";
            List<List<Point>> strokes = strokesPoints(sc);
            bool useBoundedRotationInvariance = true;
            NDollarRecognizer recognize = new NDollarRecognizer(name, strokes, multistrokes, useBoundedRotationInvariance);
            return recognize.result.Name;
        }

        #endregion

        #region Stroke intersections
        //Check strokes intersections
        private bool strokesIntersection(Stroke s1, Stroke s2)
        {
            StylusPointCollection colStylusPoints1 = s1.StylusPoints;
            StylusPointCollection colStylusPoints2 = s2.StylusPoints;
            foreach (Point point1 in colStylusPoints1)
            {
                foreach (Point point2 in colStylusPoints2)
                {
                    //If two points from two different strokes execatly intersected within 5 threshold then return true
                    if ((Math.Abs(point1.X - point2.X) < 5) && (Math.Abs(point1.Y - point2.Y) < 5))
                    {
                        return true;
                    }
                    
                }
            }
            return false;
        }
        #endregion

        private void strokeCollected(object sender, InkCanvasStrokeCollectedEventArgs e)
        {
            //Dummy message to show user that the system in ink mode each time a he/she draws a stroke
            textBox1.Text = "Ink Mode";
        }

        #endregion

        #region Delete Saved Templates

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (multistrokes.Count == 0)
            {
                textBox1.Text = "There are no saved Templates";
            }
            else
            {
                multistrokes.Clear();
                count0 = 0; count1 = 0; count2 = 0; count3 = 0; count4 = 0; count5 = 0;
                count6 = 0; count7 = 0; count8 = 0; count9 = 0; count10 = 0; count11 = 0;
                count12 = 0; count13 = 0; count14 = 0;
                textBlock1.Text = ">>>" + count0 + " samples are saved per sympol 0\n>>>" + count1 + " samples are saved per sympol 1\n>>>" + count2 + " samples are saved per sympol 2\n>>>" + count3 + " samples are saved per sympol 3\n>>>" + count4 + " samples are saved per sympol 4\n>>>" + count5 + " samples are saved per sympol 5\n>>>" + count6 + " samples are saved per sympol 6\n>>>" + count7 + " samples are saved per sympol 7\n>>>" + count8 + " samples are saved per sympol 8\n>>>" + count9 + " samples are saved per sympol 9\n>>>" + count10 + " samples are saved per sympol +\n>>>" + count11 + " samples are saved per sympol -\n>>>" + count12 + " samples are saved per sympol *\n>>>" + count14 + " samples are saved per sympol sqrt";
                textBox1.Text = "Saved Templates are deleted";
            }
        }

        #endregion

    }
}
