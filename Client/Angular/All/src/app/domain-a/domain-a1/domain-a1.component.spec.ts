import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DomainA1Component } from './domain-a1.component';

describe('DomainA1Component', () => {
  let component: DomainA1Component;
  let fixture: ComponentFixture<DomainA1Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DomainA1Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DomainA1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
