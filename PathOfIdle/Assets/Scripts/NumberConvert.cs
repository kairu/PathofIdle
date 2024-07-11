using UnityEngine;
using System.Collections;
using BigNumber;
using integer128;
public class NumberConvert : MonoBehaviour {

	private static NumberConvert instance;
	public static NumberConvert Instance{
		get{
			return instance;
		}
	}

	void Awake(){
		CreateInstance ();
	}

	void CreateInstance(){
		if (instance == null) {
			instance = this;
		}
		
	}

	//int ctr;
	public string getNumbersIntoString(BigInteger valueToConvert){
		string currencyConverted;
		double valueGet;
		valueGet = double.Parse (valueToConvert.ToString());
		/*if(valueToConvert >= 100000){
			currencyConverted = (valueToConvert / 100000f).ToString("f3") + "K";
			ctr = 1;
		}
		if(valueToConvert >= 1000000 && ctr == 1){
			currencyConverted = (valueToConvert / 1000000f).ToString("f3") + "M";
			ctr = 2;
		}
		if(valueToConvert >= 1000000000 && ctr == 2){
			currencyConverted = (valueToConvert / 1000000000f).ToString("f3") + "B";
			ctr = 3;
		}*/
		//decimal result;

		if ( valueGet >= System.Convert.ToDouble(System.Math.Pow(10,303))) {
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow (10,303))).ToString ("f2") + " **";
		} else if (valueGet >= System.Convert.ToDouble(System.Math.Pow(10,100))) {
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,100))).ToString ("f2") + " *";
		} else if(valueGet >= System.Convert.ToDouble(System.Math.Pow(10,63))){
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,63))).ToString ("f2") + " &";
		}else if( valueGet >= System.Convert.ToDouble(System.Math.Pow(10,60))){
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,60))).ToString ("f2") + " ^";
		}else if(valueGet >= System.Convert.ToDouble(System.Math.Pow(10,57))){
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,57))).ToString ("f2") + " %";
		}else if(valueGet >= System.Convert.ToDouble(System.Math.Pow(10,54))){
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,54))).ToString ("f2") + " $";
		}else if(valueGet >= System.Convert.ToDouble(System.Math.Pow(10,51))){
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,51))).ToString ("f2") + " #";
		}else if(valueGet >= System.Convert.ToDouble(System.Math.Pow(10,48))){
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,48))).ToString ("f2") + " @";
		}else if(valueGet >= System.Convert.ToDouble(System.Math.Pow(10,45))){
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,45))).ToString ("f2") + " !!";
		}else if(valueGet >= System.Convert.ToDouble(System.Math.Pow(10,42))){
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,42))).ToString ("f2") + " !";
		}else if(valueGet >= System.Convert.ToDouble(System.Math.Pow(10,39))){
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,39))).ToString ("f2") + " D";
		}else if(valueGet >= System.Convert.ToDouble(System.Math.Pow(10,36))){
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,36))).ToString ("f2") + " U";
		}else if(valueGet >= System.Convert.ToDouble(System.Math.Pow(10,33))){
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,33))).ToString ("f2") + " d";
		}else if(valueGet >= System.Convert.ToDouble(System.Math.Pow(10,30))){
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,30))).ToString ("f2") + " N";
		}else if(valueGet >= System.Convert.ToDouble(System.Math.Pow(10,27))){
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,27))).ToString ("f2") + " O";
		}else if(valueGet >= System.Convert.ToDouble(System.Math.Pow(10,24))){
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,24))).ToString ("f2") + " S";
		}else if(valueGet >= System.Convert.ToDouble(System.Math.Pow(10,21))){
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,21))).ToString ("f2") + " s";
		}else if(valueGet >= System.Convert.ToDouble(System.Math.Pow(10,18))){
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,18))).ToString ("f2") + " Q";
		}else if(valueGet >= System.Convert.ToDouble(System.Math.Pow(10,15))){
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,15))).ToString ("f2") + " q";
		}else if(valueGet >= System.Convert.ToDouble(System.Math.Pow(10,12))){
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,12))).ToString ("f2") + " T";
		}else if(valueGet >= System.Convert.ToDouble(System.Math.Pow(10,9))){
			currencyConverted = (valueGet /System.Convert.ToDouble(System.Math.Pow(10,9))).ToString ("f2") + " B";
		}else if(valueGet >= System.Convert.ToDouble(System.Math.Pow(10,6))){
			currencyConverted = (valueGet / System.Convert.ToDouble(System.Math.Pow(10,6))).ToString ("f2") + " M";
		}else{
			currencyConverted = "" +valueGet.ToString("F0");
		}
	
		/*if (currencyPerClick) {
			currencyConverted = currencyConverted +" ";
		}
		
		if (currencyPerSec) {
			currencyConverted = currencyConverted +" ";
		}*/
		return currencyConverted;
	}
	/*1000000000000000000000000000000000000000000000000000000000000000
	1K = 1,000 = One Thousand
	1M = 1,000K = One Million
	1B = 1,000M = One Billion
	1T = 1,000B = One Trillion
	1q = 1,000T = One Quadrillion
	1Q = 1,000q = One Quintillion
	1s = 1,000Q = One Sextillion
	1S = 1,000s = One Septillion
	1O = 1,000S = One Octillion
	1N = 1,000O = One Nonillion
	1d = 1,000N = One Decillion
	1U = 1,000d = One Undecillion
	1D = 1,000U = One Duodecillion
	1! = 1,000D = One Tredecillion
	1@ = 1,000! = One Quattuordecillion
	1# = 1,000@ = One Quindecillion
	1$ = 1,000# = One Sexdecillion
	1% = 1,000$ = One Septendecillion
	1^ = 1,000% = One Octodecillion
	1& = 1,000^ = One Novemdecillion
	1* = 1,000& = One Vigintillion
	A lot > 1,000* < A lot
	 */
}
