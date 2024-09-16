import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CdbCalcComponent } from './cdb-calc.component';

describe('CdbCalcComponent', () => {
  let component: CdbCalcComponent;
  let fixture: ComponentFixture<CdbCalcComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CdbCalcComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CdbCalcComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
