import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SkiLengthCalculatorComponent } from './ski-length-calculator.component';

describe('SkiLengthCalculatorComponent', () => {
  let component: SkiLengthCalculatorComponent;
  let fixture: ComponentFixture<SkiLengthCalculatorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SkiLengthCalculatorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SkiLengthCalculatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
