import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Featuer1Component } from './featuer-1.component';

describe('Featuer1Component', () => {
  let component: Featuer1Component;
  let fixture: ComponentFixture<Featuer1Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Featuer1Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Featuer1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
