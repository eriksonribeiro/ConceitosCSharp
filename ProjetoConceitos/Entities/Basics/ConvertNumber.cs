namespace ProjetoConceitos
{
    public class ConvertNumber
    {
        private int _myNumber;
        private string _myStringNumber;
        private string _myMessage;

        public ConvertNumber(string myStringNumber)
        {
            this._myStringNumber = myStringNumber;
        }
        public string TryConvertion()
        {

            if (int.TryParse(_myStringNumber, out _myNumber))
                _myMessage = $"The word {_myStringNumber} was converted to number {_myNumber}";
            else
                _myMessage = $"Was not possible to convert word {_myStringNumber} to an integer number";

            return _myMessage;
        }
    }
}