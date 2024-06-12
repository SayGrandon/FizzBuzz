import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FizzbuzzCalcComponent } from './fizzbuzz-calc.component';

describe('FizzbuzzCalcComponent', () => {
  let component: FizzbuzzCalcComponent;
  let fixture: ComponentFixture<FizzbuzzCalcComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FizzbuzzCalcComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FizzbuzzCalcComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
