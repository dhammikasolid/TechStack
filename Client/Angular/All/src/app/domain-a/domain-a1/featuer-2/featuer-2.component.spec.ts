import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Featuer2Component } from './featuer-2.component';

describe('Featuer2Component', () => {
  let component: Featuer2Component;
  let fixture: ComponentFixture<Featuer2Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Featuer2Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Featuer2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
