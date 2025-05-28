import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppraisalComponent } from './appraisal.component';

describe('AppraisalComponent', () => {
  let component: AppraisalComponent;
  let fixture: ComponentFixture<AppraisalComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AppraisalComponent]
    });
    fixture = TestBed.createComponent(AppraisalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
