import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FizzBuzzResponse } from '../models/fizzbuzz-model';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

interface ApiResponse {
  fizzBuzzValue: string;
  fizzBuzzDivisions: Array<string>;
}

@Injectable({
  providedIn: 'root'
})
export class FizzbuzzCalcService {
  private _apiResult: FizzBuzzResponse = {
    fizzBuzzValue: "",
    fizzBuzzDivisions: []
  };
  constructor(private http: HttpClient) { }

  //calls backend service to perform fizz buzz logic
  runCalculation(input: string): Observable<FizzBuzzResponse> {
    const apiUrl = '/FizzBuzzCalc/';
    return this.http.get<ApiResponse>(apiUrl + input).pipe(
      map((receivedData: ApiResponse) => {
        return new FizzBuzzResponse(
          receivedData.fizzBuzzValue,
          receivedData.fizzBuzzDivisions
        );
      })
    );
  }

}
