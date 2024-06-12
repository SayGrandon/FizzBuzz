import { TestBed } from '@angular/core/testing';
import { FizzBuzzResponse } from '../models/fizzbuzz-model';
import { of } from 'rxjs';

import { FizzbuzzCalcService } from './fizzbuzz-calc.service';

describe('FizzbuzzCalcService', () => {
  let service: FizzbuzzCalcService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FizzbuzzCalcService);
    let mockHttpClient = jasmine.createSpy('get').and.returnValue(of({}));
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('should return data on success', () => {
    const mockResponse: FizzBuzzResponse = {
      fizzBuzzValue: "Fizz",
      fizzBuzzDivisions: []
    };
    let mockHttpClient = jasmine.createSpy('get').and.returnValue(of(mockResponse));

    service.runCalculation("3").subscribe((user) => {
      expect(user).toEqual(
        new FizzBuzzResponse("Fizz", [])
      );
    });
  });
});
