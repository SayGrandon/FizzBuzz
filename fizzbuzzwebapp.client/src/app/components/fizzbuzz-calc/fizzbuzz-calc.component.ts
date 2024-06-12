import { Component } from '@angular/core';
import { FizzBuzzResponse } from '../../models/fizzbuzz-model';
import { FizzbuzzCalcService } from '../../services/fizzbuzz-calc.service';

@Component({
  selector: 'app-fizzbuzz-calc',
  templateUrl: './fizzbuzz-calc.component.html',
  styleUrls: ['./fizzbuzz-calc.component.css']
})
export class FizzbuzzCalcComponent {
  fizzBuzzInput: string = "";
  fizzBuzzModel: FizzBuzzResponse | undefined;

  constructor(private _fizzBuzzService: FizzbuzzCalcService) { }

  //on submit, fizz buzz service is called
  onSubmit(input: string) {
    this._fizzBuzzService.runCalculation(input).subscribe(
      (result) => {
        console.log('Data recieved:', result);
        this.fizzBuzzModel = result;
      },
      (error) => {
        console.error('Error fetching FizzBuzz data:', error);
      }
    )
  }

}
