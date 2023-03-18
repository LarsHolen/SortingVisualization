using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SortingVisualization
{
    public partial class Form1 : Form
    {
        // The obj that take care of drawing the bitmap/pictureBox
        private DrawIntArray drawIntArray;
        // The array that will be sorted
        private int[] intArray;
        // the delay in the sort algogithms, to slow them down for visualization
        private int sleep = 20;

        // Stuff needed to be able to cancle sorts while they run, since they
        // run on another thread.
        System.Threading.CancellationTokenSource cancellationTokenSource;
        System.Threading.CancellationToken cancellationToken;

        // A list of buttons, that I disable/enable during sorting
        readonly List<Button> sortButtons = new();

        // Enum with the current selected algorithm
        AlgorithmsEnum algorithm = AlgorithmsEnum.None;

        // The timer object that got the timer event for drawing 
        private static System.Windows.Forms.Timer timer;


        /// <summary>
        /// Constructor.  Does some init's
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Init();

        }

        /// <summary>
        /// Initialize whatevers needed at the start
        /// </summary>
        private void Init()
        {
            // Making a randomized intArray
            intArray = InitIntArray(pictureBox1);
            drawIntArray = new(pictureBox1, intArray);

            textBox1.Text = sleep.ToString() + " ms";
            SetCancellation();

            // Init Timer.  
            timer = new();
            timer.Interval = 20;
            timer.Tick += OnTimerEvent;
            timer.Enabled = true;

            Algorithms.SortFinished += FinishedSorting;

            sortButtons.Add(ButtonBubbleSort);
            sortButtons.Add(ButtonSelectionSort);
            sortButtons.Add(ButtonInsertSort);
            sortButtons.Add(ButtonquickSort);
            sortButtons.Add(ButtonMySort);
            sortButtons.Add(ButtonMySort2);
            sortButtons.Add(ButtonFast);
            sortButtons.Add(ButtonReset);
            sortButtons.Add(ButtonSlower);

        }

        /// <summary>
        /// Capture finished event from Algorithms and unfreeze buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishedSorting(object sender, EventArgs e)
        {
            // Have to use invoke to bypass thread problem
            this.Invoke(new MethodInvoker(delegate
            {
                UnFreezeSelectionButtons();
                Thread.Sleep(1000);
                intArray = InitIntArray(pictureBox1);
            }));
        }

        /// <summary>
        /// Tokens for being able to cancle the work on other threads
        /// </summary>
        private void SetCancellation()
        {
            cancellationTokenSource = new();
            cancellationToken = cancellationTokenSource.Token;
        }


        /// <summary>
        /// The timer Event.  Add new algo's here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTimerEvent(object sender, EventArgs e)
        {
            switch (algorithm)
            {
                case AlgorithmsEnum.None:
                    break;
                case AlgorithmsEnum.BubbleSort:
                    // Clearing out selected, so we dont run multiple tasks at once.
                    algorithm = AlgorithmsEnum.None;
                    // Running the sort at diffetent thread. pictureBox will update during sorting.
                    Task.Factory.StartNew(() => Algorithms.BubbleSort(intArray, sleep, cancellationToken), cancellationToken);

                    break;
                case AlgorithmsEnum.SelectionSort:
                    // Clearing out selected, so we dont run multiple tasks at once.
                    algorithm = AlgorithmsEnum.None;
                    // Running the sort at diffetent thread. pictureBox will update during sorting.
                    Task.Factory.StartNew(() => Algorithms.SelectionSort(intArray, sleep, cancellationToken), cancellationToken);
                    break;

                case AlgorithmsEnum.InsertionSort:
                    // Clearing out selected, so we dont run multiple tasks at once.
                    algorithm = AlgorithmsEnum.None;
                    // Running the sort at diffetent thread. pictureBox will update during sorting.
                    Task.Factory.StartNew(() => Algorithms.InsertionSort(intArray, sleep, cancellationToken), cancellationToken);
                    break;
                case AlgorithmsEnum.QuickSort:
                    // Clearing out selected, so we dont run multiple tasks at once.
                    algorithm = AlgorithmsEnum.None;
                    // Running the sort at diffetent thread. pictureBox will update during sorting.
                    Task.Factory.StartNew(() => Algorithms.QuickSort(intArray, 0, intArray.Length - 1, sleep, cancellationToken), cancellationToken);
                    break;
                case AlgorithmsEnum.MySort:
                    // Clearing out selected, so we dont run multiple tasks at once.
                    algorithm = AlgorithmsEnum.None;
                    // Running the sort at diffetent thread. pictureBox will update during sorting.
                    Task.Factory.StartNew(() => Algorithms.MySort(intArray, sleep, cancellationToken), cancellationToken);
                    break;
                case AlgorithmsEnum.MySort2:
                    // Clearing out selected, so we dont run multiple tasks at once.
                    algorithm = AlgorithmsEnum.None;
                    // Running the sort at diffetent thread. pictureBox will update during sorting.
                    Task.Factory.StartNew(() => Algorithms.MySort2(intArray, sleep, cancellationToken), cancellationToken);
                    break;

                default:
                    break;
            }

            drawIntArray.Draw(intArray);
        }




        /// <summary>
        /// Button events for changing the speed algorithms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFast_Click(object sender, EventArgs e)
        {
            sleep -= 10;
            if (sleep < 0) sleep = 0;
            textBox1.Text = sleep.ToString() + " ms";
        }

        private void ButtonMedium_Click(object sender, EventArgs e)
        {
            sleep = 25;
            textBox1.Text = sleep.ToString() + " ms";
        }

        private void ButtonSlow_Click(object sender, EventArgs e)
        {
            sleep += 10;
            textBox1.Text = sleep.ToString() + " ms";
        }


        /// <summary>
        /// Making an int[] with length of PictureBox width, and values random 0 to 
        /// PictureBox.Height
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <returns></returns>
        private static int[] InitIntArray(PictureBox pictureBox)
        {
            Random rnd = new();
            int[] iArray = new int[pictureBox.Width];
            for (int i = 0; i < iArray.Length; i++)
            {
                iArray[i] = rnd.Next(0, pictureBox.Height);
            }
            return iArray;
        }

        /// <summary>
        /// Rerandomizing the array and clearing the selected algo
        /// Redraw the pictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRandomize_Click(object sender, EventArgs e)
        {
            UnFreezeSelectionButtons();
            cancellationTokenSource.Cancel();
            algorithm = AlgorithmsEnum.None;
            intArray = InitIntArray(pictureBox1);
            drawIntArray.Draw(intArray);
        }
        #region Sort buttons:
        /// <summary>
        /// Buttons for selecting Sorts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBubbleSort_Click(object sender, EventArgs e)
        {
            SetCancellation();
            algorithm = AlgorithmsEnum.BubbleSort;
            FreezeSelectionButtons();
        }
        private void ButtonSelectionSort_Click(object sender, EventArgs e)
        {
            SetCancellation();
            algorithm = AlgorithmsEnum.SelectionSort;
            FreezeSelectionButtons();
        }
        private void ButtonInsertSort_Click(object sender, EventArgs e)
        {
            SetCancellation();
            algorithm = AlgorithmsEnum.InsertionSort;
            FreezeSelectionButtons();
        }
        private void ButtonQuickSort_Click(object sender, EventArgs e)
        {
            SetCancellation();
            algorithm = AlgorithmsEnum.QuickSort;
            FreezeSelectionButtons();
        }
        private void ButtonMySort_Click(object sender, EventArgs e)
        {
            SetCancellation();
            algorithm = AlgorithmsEnum.MySort;
            FreezeSelectionButtons();
        }
        private void ButtonMySort2_Click(object sender, EventArgs e)
        {
            SetCancellation();
            algorithm = AlgorithmsEnum.MySort2;
            FreezeSelectionButtons();
        }

        #endregion

        /// <summary>
        /// Enabling and disabling the buttons
        /// </summary>
        private void FreezeSelectionButtons()
        {
            foreach (Button button in sortButtons)
            {
                button.Enabled = false;
            }
        }
        private void UnFreezeSelectionButtons()
        {
            foreach (Button button in sortButtons)
            {
                button.Enabled = true;
            }
        }


        /// <summary>
        /// Radio Buttons for drawin lines or points
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonDrawLines_Click(object sender, EventArgs e)
        {
            drawIntArray.DrawLine = true;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }

        private void RadioButtonDrawPoints_Click(object sender, EventArgs e)
        {
            drawIntArray.DrawLine = false;
            radioButton1.Checked = false;
            radioButton2.Checked = true;
        }
    }
}
