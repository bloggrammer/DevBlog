document.addEventListener('DOMContentLoaded', function () {
  var grid = null,
    wrapper = document.querySelector('.grid-wrapper'),
    searchField = wrapper.querySelector('.search-field'),
    filterField = wrapper.querySelector('.filter-field'),
    sortField = wrapper.querySelector('.sort-field'),
    gridElem = wrapper.querySelector('.grid'),
    searchAttr = 'data-title',
    filterAttr = 'data-color',
    searchFieldValue,
    filterFieldValue,
    sortFieldValue,
    dragOrder = [];

  // Init the grid layout
  grid = new Muuri(gridElem, {
    dragEnabled: true,
  });

  // Set inital search query, active filter, active sort value and active layout.
  searchFieldValue = searchField.value.toLowerCase();
  filterFieldValue = filterField.value;
  sortFieldValue = sortField.value;

  // Search field event binding
  searchField.addEventListener('keyup', function () {
    var newSearch = searchField.value.toLowerCase();
    if (searchFieldValue !== newSearch) {
      searchFieldValue = newSearch;
      filter();
    }
  });

  // Filter field event binding
  filterField.addEventListener('change', filter);

  // Sort field event binding
  sortField.addEventListener('change', sort);

  // Filtering
  function filter() {
    filterFieldValue = filterField.value;
    grid.filter(function (item) {
      var element = item.getElement(),
        isSearchMatch = !searchFieldValue
          ? true
          : (element.getAttribute(searchAttr) || '')
              .toLowerCase()
              .indexOf(searchFieldValue) > -1,
        isFilterMatch = !filterFieldValue
          ? true
          : (element.getAttribute(filterAttr) || '') === filterFieldValue;
      return isSearchMatch && isFilterMatch;
    });
  }

  // Sorting
  function sort() {
    // Do nothing if sort value did not change.
    var currentSort = sortField.value;
    if (sortFieldValue === currentSort) {
      return;
    }

    // If we are changing from "order" sorting to something else
    // let's store the drag order.
    if (sortFieldValue === 'order') {
      dragOrder = grid.getItems();
    }

    // Sort the items.
    grid.sort(
      currentSort === 'title'
        ? compareItemTitle
        : currentSort === 'color'
        ? compareItemColor
        : dragOrder
    );
    sortFieldValue = currentSort;
  }

  // Compare data-title
  function compareItemTitle(a, b) {
    var aVal = a.getElement().getAttribute(searchAttr) || '';
    var bVal = b.getElement().getAttribute(searchAttr) || '';
    return aVal < bVal ? -1 : aVal > bVal ? 1 : 0;
  }

  // Compare data-color
  function compareItemColor(a, b) {
    var aVal = a.getElement().getAttribute(filterAttr) || '';
    var bVal = b.getElement().getAttribute(filterAttr) || '';
    return aVal < bVal ? -1 : aVal > bVal ? 1 : compareItemTitle(a, b);
  }
});
