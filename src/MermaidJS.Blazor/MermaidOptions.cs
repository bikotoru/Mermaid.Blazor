using System.Collections.Generic;
using System.Linq;

namespace MermaidJS.Blazor
{
    /// <summary>
    /// Options used when initializing MermaidJS.
    /// </summary>
    public class MermaidOptions
    {
        #region General Configuration

        /// <summary>
        /// Controls whether or arrow markers in html code are absolute paths or anchors.
        /// </summary>
        public bool ArrowMarkerAbsolute { get; set; }

        /// <summary>
        /// Specifies the font to be used in the rendered diagrams.
        /// </summary>
        public string FontFamily { get; set; } = "'trebuchet ms', verdana, arial, sans-serif;";

        /// <summary>
        /// Default font size for all text elements in diagrams.
        /// </summary>
        public int FontSize { get; set; } = 16;

        /// <summary>
        /// This option decides the amount of logging to be used.
        /// 1 = Error, 2 = Warning, 3 = Info, 4 = Debug, 5 = Trace
        /// </summary>
        public int LogLevel { get; set; } = 5;

        /// <summary>
        /// The maximum number of characters allowed in a diagram definition.
        /// </summary>
        public int MaxTextSize { get; set; } = 50000;

        /// <summary>
        /// Maximum width of the diagram in pixels. null = no max width.
        /// </summary>
        public int? MaxWidth { get; set; }

        /// <summary>
        /// This option controls which currentConfig keys are considered secure and can only be changed via call to mermaidAPI.initialize.
        /// </summary>
        public List<string> Secure { get; set; } = new string[] { "secure", "securityLevel", "startOnLoad", "maxTextSize" }.ToList();

        /// <summary>
        /// Level of trust for parsed diagram: 'strict', 'loose', or 'antiscript'.
        /// </summary>
        public string SecurityLevel { get; set; } = "strict";

        /// <summary>
        /// Dictates whether mermaid starts on Page load.
        /// </summary>
        public bool StartOnLoad { get; set; } = true;

        /// <summary>
        /// Name of a pre-defined MermaidJS theme: 'default', 'forest', 'dark', 'neutral', 'base'.
        /// </summary>
        public string Theme { get; set; } = "dark";

        /// <summary>
        /// Make diagrams draggable (interactive).
        /// </summary>
        public bool Draggable { get; set; } = false;

        /// <summary>
        /// Use HTML labels for nodes. If false plain-text labels will be used.
        /// </summary>
        public bool HtmlLabels { get; set; } = true;

        /// <summary>
        /// Use the maximum width of the parent container.
        /// </summary>
        public bool UseMaxWidth { get; set; } = true;

        #endregion

        #region Diagram-Specific Configurations

        /// <summary>
        /// Configuration options for flowchart diagrams.
        /// </summary>
        public FlowchartConfig Flowchart { get; set; } = new FlowchartConfig();

        /// <summary>
        /// Configuration options for sequence diagrams.
        /// </summary>
        public SequenceConfig Sequence { get; set; } = new SequenceConfig();

        /// <summary>
        /// Configuration options for Gantt diagrams.
        /// </summary>
        public GanttConfig Gantt { get; set; } = new GanttConfig();

        /// <summary>
        /// Configuration options for class diagrams.
        /// </summary>
        public ClassConfig Class { get; set; } = new ClassConfig();

        /// <summary>
        /// Configuration options for state diagrams.
        /// </summary>
        public StateConfig State { get; set; } = new StateConfig();

        /// <summary>
        /// Configuration options for entity-relationship diagrams.
        /// </summary>
        public ErConfig Er { get; set; } = new ErConfig();

        /// <summary>
        /// Configuration options for pie charts.
        /// </summary>
        public PieConfig Pie { get; set; } = new PieConfig();

        /// <summary>
        /// Configuration options for user journey diagrams.
        /// </summary>
        public JourneyConfig Journey { get; set; } = new JourneyConfig();

        #endregion

        #region Nested Configuration Classes

        /// <summary>
        /// Configuration options for flowchart diagrams.
        /// </summary>
        public class FlowchartConfig
        {
            /// <summary>
            /// Use HTML labels for nodes. If false plain-text labels will be used.
            /// </summary>
            public bool HtmlLabels { get; set; } = true;

            /// <summary>
            /// Type of curve for edges: 'basis', 'linear', 'cardinal'.
            /// </summary>
            public string Curve { get; set; } = "linear";

            /// <summary>
            /// Padding around the diagram.
            /// </summary>
            public int DiagramPadding { get; set; } = 8;

            /// <summary>
            /// Horizontal spacing between nodes.
            /// </summary>
            public int NodeSpacing { get; set; } = 50;

            /// <summary>
            /// Vertical spacing between nodes on different levels.
            /// </summary>
            public int RankSpacing { get; set; } = 50;

            /// <summary>
            /// Use the maximum width of the parent container.
            /// </summary>
            public bool UseMaxWidth { get; set; } = true;

            /// <summary>
            /// Default direction of the flowchart: 'TB', 'TD', 'BT', 'RL', 'LR'.
            /// </summary>
            public string DefaultDirection { get; set; } = "TB";
        }

        /// <summary>
        /// Configuration options for sequence diagrams.
        /// </summary>
        public class SequenceConfig
        {
            /// <summary>
            /// Margin on the left and right side of the diagram.
            /// </summary>
            public int DiagramMarginX { get; set; } = 50;

            /// <summary>
            /// Margin on the top and bottom side of the diagram.
            /// </summary>
            public int DiagramMarginY { get; set; } = 10;

            /// <summary>
            /// Spacing between actors.
            /// </summary>
            public int ActorMargin { get; set; } = 50;

            /// <summary>
            /// Width of actor boxes.
            /// </summary>
            public int Width { get; set; } = 150;

            /// <summary>
            /// Height of actor boxes.
            /// </summary>
            public int Height { get; set; } = 65;

            /// <summary>
            /// Spacing around loop boxes.
            /// </summary>
            public int BoxMargin { get; set; } = 10;

            /// <summary>
            /// Margin around text in loop/alt/opt boxes.
            /// </summary>
            public int BoxTextMargin { get; set; } = 5;

            /// <summary>
            /// Margin around notes.
            /// </summary>
            public int NoteMargin { get; set; } = 10;

            /// <summary>
            /// Margin between messages.
            /// </summary>
            public int MessageMargin { get; set; } = 35;

            /// <summary>
            /// Mirror actors at the bottom of the diagram.
            /// </summary>
            public bool MirrorActors { get; set; } = true;

            /// <summary>
            /// Margin adjustment for bottom actors.
            /// </summary>
            public int BottomMarginAdj { get; set; } = 1;

            /// <summary>
            /// Use the maximum width of the parent container.
            /// </summary>
            public bool UseMaxWidth { get; set; } = true;
        }

        /// <summary>
        /// Configuration options for Gantt diagrams.
        /// </summary>
        public class GanttConfig
        {
            /// <summary>
            /// Margin at the top of the Gantt diagram.
            /// </summary>
            public int TitleTopMargin { get; set; } = 25;

            /// <summary>
            /// Height of the bars in the Gantt diagram.
            /// </summary>
            public int BarHeight { get; set; } = 20;

            /// <summary>
            /// Gap between bars in the Gantt diagram.
            /// </summary>
            public int BarGap { get; set; } = 4;

            /// <summary>
            /// Top padding for the Gantt diagram.
            /// </summary>
            public int TopPadding { get; set; } = 50;

            /// <summary>
            /// Left padding for the Gantt diagram.
            /// </summary>
            public int LeftPadding { get; set; } = 75;

            /// <summary>
            /// Padding before the grid lines start.
            /// </summary>
            public int GridLineStartPadding { get; set; } = 35;

            /// <summary>
            /// Font size for the Gantt diagram.
            /// </summary>
            public int FontSize { get; set; } = 11;

            /// <summary>
            /// Font family for the Gantt diagram.
            /// </summary>
            public string FontFamily { get; set; } = "'Open Sans', sans-serif";

            /// <summary>
            /// Number of different section styles.
            /// </summary>
            public int NumberSectionStyles { get; set; } = 4;

            /// <summary>
            /// Format of the axis for the Gantt diagram.
            /// </summary>
            public string AxisFormat { get; set; } = "%Y-%m-%d";

            /// <summary>
            /// Use the maximum width of the parent container.
            /// </summary>
            public bool UseMaxWidth { get; set; } = true;
        }

        /// <summary>
        /// Configuration options for class diagrams.
        /// </summary>
        public class ClassConfig
        {
            /// <summary>
            /// Margin at the top of the class diagram.
            /// </summary>
            public int TitleTopMargin { get; set; } = 25;

            /// <summary>
            /// Controls whether or arrow markers are absolute paths or anchors.
            /// </summary>
            public bool ArrowMarkerAbsolute { get; set; } = false;

            /// <summary>
            /// Use the maximum width of the parent container.
            /// </summary>
            public bool UseMaxWidth { get; set; } = true;
        }

        /// <summary>
        /// Configuration options for state diagrams.
        /// </summary>
        public class StateConfig
        {
            /// <summary>
            /// Margin between the different states.
            /// </summary>
            public int DividerMargin { get; set; } = 10;

            /// <summary>
            /// Base size unit for the diagram.
            /// </summary>
            public int SizeUnit { get; set; } = 5;

            /// <summary>
            /// Padding around states.
            /// </summary>
            public int Padding { get; set; } = 8;

            /// <summary>
            /// Use the maximum width of the parent container.
            /// </summary>
            public bool UseMaxWidth { get; set; } = true;
        }

        /// <summary>
        /// Configuration options for entity-relationship diagrams.
        /// </summary>
        public class ErConfig
        {
            /// <summary>
            /// Padding around the diagram.
            /// </summary>
            public int DiagramPadding { get; set; } = 20;

            /// <summary>
            /// Direction of the diagram: 'TB', 'TD', 'BT', 'RL', 'LR'.
            /// </summary>
            public string LayoutDirection { get; set; } = "TB";

            /// <summary>
            /// Minimum width of an entity.
            /// </summary>
            public int MinEntityWidth { get; set; } = 100;

            /// <summary>
            /// Minimum height of an entity.
            /// </summary>
            public int MinEntityHeight { get; set; } = 75;

            /// <summary>
            /// Padding around entities.
            /// </summary>
            public int EntityPadding { get; set; } = 15;

            /// <summary>
            /// Use the maximum width of the parent container.
            /// </summary>
            public bool UseMaxWidth { get; set; } = true;
        }

        /// <summary>
        /// Configuration options for pie charts.
        /// </summary>
        public class PieConfig
        {
            /// <summary>
            /// Use width of the container to set chart size.
            /// </summary>
            public bool UseWidth { get; set; } = true;

            /// <summary>
            /// Position of the labels in the chart (0-1).
            /// </summary>
            public double TextPosition { get; set; } = 0.5;
        }

        /// <summary>
        /// Configuration options for user journey diagrams.
        /// </summary>
        public class JourneyConfig
        {
            /// <summary>
            /// Margin on the left and right side of the diagram.
            /// </summary>
            public int DiagramMarginX { get; set; } = 50;

            /// <summary>
            /// Margin on the top and bottom side of the diagram.
            /// </summary>
            public int DiagramMarginY { get; set; } = 10;

            /// <summary>
            /// Spacing between actors.
            /// </summary>
            public int ActorMargin { get; set; } = 50;

            /// <summary>
            /// Width of actor boxes.
            /// </summary>
            public int Width { get; set; } = 150;

            /// <summary>
            /// Height of actor boxes.
            /// </summary>
            public int Height { get; set; } = 65;

            /// <summary>
            /// Spacing around boxes.
            /// </summary>
            public int BoxMargin { get; set; } = 10;

            /// <summary>
            /// Use the maximum width of the parent container.
            /// </summary>
            public bool UseMaxWidth { get; set; } = true;
        }

        #endregion
    }
}
