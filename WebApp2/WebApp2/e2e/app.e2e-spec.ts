import { AspcoreAngularPage } from './app.po';

describe('aspcore-angular App', () => {
  let page: AspcoreAngularPage;

  beforeEach(() => {
    page = new AspcoreAngularPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!');
  });
});
